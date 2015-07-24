using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Net;
using System.IO;
using Android.Widget;
using Com.Tencent.MM.Sdk.Modelpay;
using Utils;
using System.Security.Cryptography;
using MonoWithWeChartSDK.Component;
using Android.App;
using Android.OS;

namespace MonoWithWeChartSDK
{
    /*MD5大写 SHA1小写*/
    public class GetPrepayIdTask : AsyncTask<Java.Lang.String, int, string>
    {
        private static readonly DateTime Jan1st1970 = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        private Activity _activity;
        private SimpleDialog _progressDialog;
        private static string ERR_TIP = "获取预付单失败";
        public string TraceId { get; set; }//商家对用户的唯一标识，APP支付为UserId，公众号支付（微信浏览器内）使用OpenId
        public string Noncestr { get; set; }//32位随机字符串
        public string Package { get; set; }//订单详情
        public long Timestamp { get; set; }//时间戳
        public string AppId { get; set; }//你的微信应用的唯一标识，
        public string AppSignature { get; set; }//签名
        public string AppKey { get; set; }
        public string AccessToken { get; set; }
        public static readonly string GET_PREPAY_URL = "https://api.weixin.qq.com/pay/genprepay?access_token={0}";
        public GetPrepayIdTask(Activity a, string accessToken)
        {
            /*请不要修改构造函数的执行顺序*/
            _activity = a;
            AccessToken = accessToken;
            TraceId = GetTraceId();
            Noncestr = System.Guid.NewGuid().ToString().Replace("-", "");
            Timestamp = GetTimeStamp();
            Package = GetPackage();//业务逻辑请自行完成
            AppId = Constants.APP_ID;
            AppKey = Constants.APP_KEY;
            AppSignature = GetAppSignature();
            _progressDialog = new SimpleDialog(_activity, "正在获取预付单");
        }
        public static long CurrentTimeMillis()
        {
            return (long)(DateTime.UtcNow - Jan1st1970).TotalMilliseconds;
        }
        private long GetTimeStamp()
        {
            return CurrentTimeMillis() / 1000;
        }
        public string GetAppSignature()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("appid").Append("=").Append(AppId).Append("&");
            sb.Append("appkey").Append("=").Append(AppKey).Append("&");
            sb.Append("noncestr").Append("=").Append(Noncestr).Append("&");
            sb.Append("package").Append("=").Append(Package).Append("&");
            sb.Append("timestamp").Append("=").Append(Timestamp).Append("&");
            sb.Append("traceid").Append("=").Append(TraceId);
            HashAlgorithm hashAlg = HashAlgorithm.Create("SHA1");
            string hashResult = BitConverter.ToString(hashAlg.ComputeHash(Encoding.UTF8.GetBytes(sb.ToString()))).ToLower();
            return hashResult.Replace("-", "");
        }
        public string GetPackage()
        {
            Dictionary<string, string> nameValuePair = new Dictionary<string, string>();
            nameValuePair.Add("bank_type", "WX");//银行通道类型
            nameValuePair.Add("body", "支付测试");//商品描述
            nameValuePair.Add("fee_type", "1");//币种，1为人民币
            nameValuePair.Add("input_charset", "UTF-8");//字符串种类
            nameValuePair.Add("notify_url", "http://120.25.156.238/Ping/Notify.aspx");//填入服务器回调地址
            nameValuePair.Add("out_trade_no", System.Guid.NewGuid().ToString().Replace("-", ""));//商户订单号
            nameValuePair.Add("partner", "1900000109");//商户号
            nameValuePair.Add("spbill_create_ip", "196.168.1.1");//生成订单的客户端IP
            nameValuePair.Add("total_fee", "1");//订单价格
            StringBuilder sb = new StringBuilder();
            HttpUtil.AppendUrl(ref sb, nameValuePair, true);
            sb.Append("key").Append("=").Append(Constants.PARTNER_KEY);
            HashAlgorithm hashAlg = HashAlgorithm.Create("MD5");
            string hashResult = BitConverter.ToString(hashAlg.ComputeHash(Encoding.UTF8.GetBytes(sb.ToString()))).ToUpper().Replace("-", "");
            HttpUtil.AppendUrlEncoded(ref sb, nameValuePair, false);
            string urlEncodedResult = sb.ToString();
            return urlEncodedResult + "&sign=" + hashResult;

        }
        private string GetTraceId()
        {
            return "swjtu_" + GetTimeStamp();
        }
        protected override void OnPreExecute()
        {
            base.OnPreExecute();
            _progressDialog.Show();

        }
        protected override string RunInBackground(params Java.Lang.String[] @params)
        {
            var config = new
            {
                appid = AppId,
                traceid = TraceId,
                noncestr = Noncestr,
                timestamp = Timestamp,
                package = Package,
                sign_method = "sha1",
                app_signature = AppSignature
            };

            var postJson = JsonConvert.SerializeObject(config);
            var http = (HttpWebRequest)WebRequest.Create(string.Format(GET_PREPAY_URL, @params[0]));
            http.ContentType = "application/json";
            http.Accept = "application/json";
            http.Method = "POST";
            UTF8Encoding encoding = new UTF8Encoding();
            Byte[] bytes = encoding.GetBytes(postJson);
            Stream newStream = http.GetRequestStream();
            newStream.Write(bytes, 0, bytes.Length);
            newStream.Close();
            try
            {
                var response = http.GetResponse();
                var stream = response.GetResponseStream();
                var sr = new StreamReader(stream);
                var content = sr.ReadToEnd();
                dynamic returnJson = JsonConvert.DeserializeObject(content);
                var prepayid = returnJson["prepayid"];
                return prepayid;
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                return ERR_TIP;
            }
        }
        protected override void OnPostExecute(string result)
        {
            _progressDialog.Cancel();
            if (result.Equals(ERR_TIP))
            {
                Toast.MakeText(_activity, "获取预付单失败", ToastLength.Short);


            }
            else
            {
                string prepayid = result;
                string accessToken = this.AccessToken;
                PayReq req = new PayReq();
                req.AppId = this.AppId;
                req.PartnerId = Constants.PARTNER_ID;
                req.PrepayId = prepayid;
                req.NonceStr = this.Noncestr;
                req.TimeStamp = this.Timestamp.ToString();
                req.PackageValue = "Sign=Wxpay";
                StringBuilder sb = new StringBuilder();
                Dictionary<string, string> nameValuePair = new Dictionary<string, string>();
                nameValuePair.Add("appid", req.AppId);
                nameValuePair.Add("appkey", Constants.APP_KEY);
                nameValuePair.Add("noncestr", req.NonceStr);
                nameValuePair.Add("package", req.PackageValue);
                nameValuePair.Add("partnerid", req.PartnerId);
                nameValuePair.Add("prepayid", req.PrepayId);
                nameValuePair.Add("timestamp", req.TimeStamp);
                HttpUtil.AppendUrl(ref sb, nameValuePair, false);
                HashAlgorithm hashAlg = HashAlgorithm.Create("SHA1");
                req.Sign = BitConverter.ToString(hashAlg.ComputeHash(Encoding.UTF8.GetBytes(sb.ToString()))).ToLower().Replace("-", "");
                ((SimplePayment)_activity).Api.SendReq(req);
            }
        }
    }
}
