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

namespace MonoWithWeChartSDK.Component
{
    public class SimpleDialog
    {
        private Dialog _progressDialog;
        public SimpleDialog(Activity a,string tip)
        {
            _progressDialog = new Dialog(a, Resource.Style.progress_dialog);
            _progressDialog.SetContentView(Resource.Layout.SimpleDialog);
            _progressDialog.SetCancelable(true);
            _progressDialog.Window.SetBackgroundDrawableResource(Android.Resource.Color.Transparent);
            TextView msg = (TextView)_progressDialog.FindViewById(Resource.Id.id_tv_loadingmsg);
            msg.Text = tip;
        }
        public void Show()
        {
            _progressDialog.Show();
        }
        public void Cancel()
        {
            _progressDialog.Cancel();
        }
    }
}