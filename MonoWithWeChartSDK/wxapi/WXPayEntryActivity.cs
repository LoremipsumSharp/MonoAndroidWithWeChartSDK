using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Views;
using Android.Widget;
using Com.Tencent.MM.Sdk.Openapi;
using Com.Tencent.MM.Sdk.Constants;
using MonoWithWeChartSDK;


namespace wxapi
{
    public class WXPayEntryActivity : Activity, IWXAPIEventHandler
    {
        private IWXAPI api;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.payresult);
            api = WXAPIFactory.CreateWXAPI(this, Constants.APP_ID);
            api.HandleIntent(Intent, this);
            Toast.MakeText(this, PackageName, ToastLength.Long).Show();
        }

        public void OnReq(Com.Tencent.MM.Sdk.Modelbase.BaseReq p0)
        {

        }

        public void OnResp(Com.Tencent.MM.Sdk.Modelbase.BaseResp p0)
        {
            if (p0.Type == ConstantsAPI.CommandPayByWx)
            {
                AlertDialog.Builder builder = new AlertDialog.Builder(this);
                builder.SetTitle("Ö§¸¶½á¹û");
                builder.SetMessage(GetString(Resource.String.pay_result_callback_msg, p0.errCode_Rename.ToString()));
                builder.Show();
            }
        }
        protected override void OnNewIntent(Intent intent)
        {
            Intent = intent;
            api.HandleIntent(intent, this);
        }
    }
}