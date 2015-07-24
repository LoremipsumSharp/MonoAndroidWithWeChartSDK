using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonoWithWeChartSDK
{

    public static class Constants
    {
        public static readonly string APP_ID = "wxd930ea5d5a258f4f";
        public static readonly string APP_SECRET = "db426a9829e4b49a0dcac7b4162da6b6";//微信开放平台和商户约定的密钥
        public static readonly string APP_KEY = "L8LrMqqeGRxST5reouB0K66CaYAWpqhAVsq7ggKkxHCOastWksvuX1uvmvQclxaHoYd3ElNBrNO2DHnnzgfVG9Qs473M3DTOZug5er46FhuGofumV8H2FVR9qkjSlC5K";//微信开放平台和商户约定的支付密钥，Alias：pay_sign_key
        public static readonly string GET_ACCESSTOKEN_URL = "https://api.weixin.qq.com/cgi-bin/token?grant_type=client_credential&appid=" + APP_ID + "&secret=" + APP_SECRET;
        public static readonly string PARTNER_KEY = "8934e7d15453e97507ef794cf7b0519d";//财付通密钥
        public static readonly string PARTNER_ID = "1900000109";
    }
}