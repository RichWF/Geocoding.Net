using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geocoding.Net.Baidu
{
    public class BaiduPoints
    {
        public static string apiUrl = "http://api.map.baidu.com/geocoder/v2/?address={0}&output=json&ak=z1DGYGWmYejI7q2rW4W9KuWL";

        /// <summary>
        /// 根据位置信息编译出经纬度
        /// </summary>
        /// <param name="location"></param>
        /// <returns></returns>
        public static BaiduPoint GetBaiduLngLatByLocation(string location)
        {
            string url = string.Format(apiUrl, location);

            BaiduPoint model = new BaiduPoint();
            try
            {
                string result = GetHelper.GetResult(url);
                model = (BaiduPoint)Newtonsoft.Json.JsonConvert.DeserializeObject<BaiduPoint>(result);
            }
            catch (Exception e)
            {
                model.status = 999; //访问接口或者转化过程发生异常
            }
            return model;
        }
    }
}
