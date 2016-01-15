using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geocoding.Net.Gaode
{
    public class GaodePoints
    {
        public static string apiUrl = "http://restapi.amap.com/v3/geocode/geo?address={0}&output=json&key=eb24db11efa9de4e6e07689e6847fa57";
        /// <summary>
        /// 根据位置信息编译出经纬度
        /// </summary>
        /// <param name="location"></param>
        /// <returns></returns>
        public static GaodePoint GetGaodeLngLatByLocation(string location)
        {
            string url = string.Format(apiUrl, location);

            GaodePoint model = new GaodePoint();
            try
            {
                string result = GetHelper.GetResult(url);
                model = (GaodePoint)Newtonsoft.Json.JsonConvert.DeserializeObject<GaodePoint>(result);
            }
            catch (Exception e)
            {
                model.status = "999";
                model.info = e.Message;
            }
            return model;
        }
    }
}
