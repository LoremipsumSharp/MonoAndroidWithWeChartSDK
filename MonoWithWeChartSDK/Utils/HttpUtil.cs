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
using System.Net;
using System.IO;

namespace Utils
{
    public class HttpUtil
    {
        public static void AppendUrlEncoded(ref StringBuilder sb, string name, string value, bool hasMore)
        {

            sb.Append(WebUtility.UrlEncode(name));
            sb.Append("=");
            sb.Append(WebUtility.UrlEncode(value));
            if (hasMore)
                sb.Append("&");
        }
        public static void AppendUrlEncoded(ref StringBuilder sb, Dictionary<string, string> nameValuePair, bool isNeedAmp)
        {
            sb.Clear();
            string[] sortedKeys = nameValuePair.Keys.OrderBy(x => x).ToArray();
            if (isNeedAmp)
            {

                for (int i = 0; i < sortedKeys.Length; i++)
                {
                    sb.Append(WebUtility.UrlEncode(sortedKeys[i])).Append("=").Append(WebUtility.UrlEncode(nameValuePair[sortedKeys[i]])).Append("&");
                }
            }
            else
            {
                for (int i = 0; i < sortedKeys.Length - 1; i++)
                {
                    sb.Append(WebUtility.UrlEncode(sortedKeys[i])).Append("=").Append(WebUtility.UrlEncode(nameValuePair[sortedKeys[i]])).Append("&");
                }
                sb.Append(WebUtility.UrlEncode(sortedKeys[sortedKeys.Length - 1])).Append("=").Append(WebUtility.UrlEncode(nameValuePair[sortedKeys[sortedKeys.Length - 1]]));
            }

        }
        public static void AppendUrl(ref StringBuilder sb, Dictionary<string, string> nameValuePair, bool isNeedAmp)
        {
            sb.Clear();
            string[] sortedKeys = nameValuePair.Keys.OrderBy(x => x).ToArray();
            if (isNeedAmp)
            {

                for (int i = 0; i < sortedKeys.Length; i++)
                {
                    sb.Append(sortedKeys[i]).Append("=").Append(nameValuePair[sortedKeys[i]]).Append("&");
                }
            }
            else
            {
                for (int i = 0; i < sortedKeys.Length - 1; i++)
                {
                    sb.Append(sortedKeys[i]).Append("=").Append(nameValuePair[sortedKeys[i]]).Append("&");
                }
                sb.Append(sortedKeys[sortedKeys.Length - 1]).Append("=").Append(nameValuePair[sortedKeys[sortedKeys.Length - 1]]);
            }
        }
        public static string GetJson(string url, string requestEntity)
        {
            var http = (HttpWebRequest)WebRequest.Create(url);
            http.ContentType = "application/json";
            http.Accept = "application/json";
            http.Method = "POST";
            if (requestEntity != null)
            {
                UTF8Encoding encoding = new UTF8Encoding();
                Byte[] bytes = encoding.GetBytes(requestEntity);
                Stream newStream = http.GetRequestStream();
                newStream.Write(bytes, 0, bytes.Length);
                newStream.Close();
            }
            try
            {
                var response = http.GetResponse();
                var stream = response.GetResponseStream();
                var sr = new StreamReader(stream);
                var content = sr.ReadToEnd();
                return content;
            }catch
            {
                return null;
            }
        }
    }
}