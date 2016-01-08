using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace Geocoding.Net
{
    public class GetHelper
    {

        /// <summary>
        /// Get请求
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static string GetResult(string url)
        {
            Uri uri = new Uri(url);
            WebRequest webRequest = WebRequest.Create(uri);
            webRequest.ContentType = "text/x-json;charset=UTF-8";
            webRequest.Method = "GET";

            string result = "";
            try
            {
                WebResponse webResponse = webRequest.GetResponse();
                using (StreamReader myStreamReader = new StreamReader(webResponse.GetResponseStream(), Encoding.UTF8))
                {
                    result = myStreamReader.ReadToEnd();

                }
            }
            catch (WebException we)
            {
                StreamReader Reader = new StreamReader(we.Response.GetResponseStream(), Encoding.UTF8);
                result = Reader.ReadToEnd();
            }
            return result;

        }
    }
}
