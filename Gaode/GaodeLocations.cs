using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geocoding.Net.Gaode
{
    public class GaodeLocations
    {
        public static string apiUrl = "http://restapi.amap.com/v3/geocode/regeo?output=json&location={0}&key=eb24db11efa9de4e6e07689e6847fa57&radius=1000&extensions=all";

        /// <summary>
        /// 根据经纬度反编译出位置信息
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        public static GaodeLocation GetGaodeLocationByLngLat(Point point)
        {
            string url = string.Format(apiUrl, point.Longitude + "," + point.Latitude);

            GaodeLocation model = new GaodeLocation();
            try
            {
                string result = GetHelper.GetResult(url);
                model = (GaodeLocation)Newtonsoft.Json.JsonConvert.DeserializeObject<GaodeLocation>(result);
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
