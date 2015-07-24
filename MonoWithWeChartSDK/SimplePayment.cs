using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Com.Tencent.MM.Sdk.Openapi;


namespace MonoWithWeChartSDK
{
    [Activity(Label = "My Activity",MainLauncher=true)]
    public class SimplePayment : Activity
    {
        private Button button = null;
        public IWXAPI Api { get; private set; }
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            Api = WXAPIFactory.CreateWXAPI(this, Constants.APP_ID, false);
            SetContentView(Resource.Layout.Main);
            //   Api.RegisterApp(Constants.APP_ID);
            button = FindViewById<Button>(Resource.Id.MyButton);
            button.Click += OnClick;

        }
        public void OnClick(object sender, EventArgs evtArgs)
        {
            new GetAccessToken(this).Execute();
            button.Enabled = false;
        }
    }
}