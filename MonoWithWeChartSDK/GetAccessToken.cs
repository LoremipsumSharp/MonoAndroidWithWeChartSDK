using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.OS;
using Android.App;
using Android.Widget;
using System.IO;
using Newtonsoft.Json;
using System.Net;
using MonoWithWeChartSDK.Component;

namespace MonoWithWeChartSDK
{
    public class GetAccessToken : AsyncTask<Java.Lang.Void, Java.Lang.Void, string>
    {
        private Activity _activity;
        private SimpleDialog _progressDialog;
        private static string ERR_TIP = "获取ACCESSTOKEN失败";
        public GetAccessToken(Activity a)
        {
            _activity = a;
        }
        protected override void OnPreExecute()
        {
            base.OnPreExecute();
            if (_progressDialog == null)
            {
                _progressDialog = new SimpleDialog(_activity, "正在获取AccessToken");
                _progressDialog.Show();
            }
        }
        protected override string RunInBackground(params Java.Lang.Void[] @params)
        {
            var http = (HttpWebRequest)WebRequest.Create(Constants.GET_ACCESSTOKEN_URL);
            http.Accept = "application/json";
            http.Method = "GET";
            try
            {
                var response = http.GetResponse();
                var stream = response.GetResponseStream();
                var sr = new StreamReader(stream);
                var content = sr.ReadToEnd();
                dynamic result = JsonConvert.DeserializeObject(content);
                return (string)result["access_token"];

            }
            catch
            {
                return ERR_TIP;
            }
        }
        protected override void OnPostExecute(string result)
        {
            _progressDialog.Cancel();
            if (result.Equals(ERR_TIP))
            {
                Toast.MakeText(_activity, "获取AccessToken失败", ToastLength.Long);
                return;
            }
            Toast.MakeText(_activity, "获取AccessToken成功", ToastLength.Short);
            new GetPrepayIdTask(_activity, result).Execute(result);
        }
    }
}
