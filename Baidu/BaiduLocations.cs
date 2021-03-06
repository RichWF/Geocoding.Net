﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geocoding.Net.Baidu
{
    public class BaiduLocations
    {
        public static string apiUrl = "http://api.map.baidu.com/geocoder/v2/?ak=z1DGYGWmYejI7q2rW4W9KuWL&location={0}&output=json&pois=1";
        /// <summary>
        /// 根据经纬度反编译出位置信息
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        public static BaiduLocation GetBaiduLocationByLngLat(Point point)
        {
            string url = string.Format(apiUrl, point.Latitude + "," + point.Longitude);

            BaiduLocation model = new BaiduLocation();
            try
            {
                string result = GetHelper.GetResult(url);
                model = (BaiduLocation)Newtonsoft.Json.JsonConvert.DeserializeObject<BaiduLocation>(result);
            }
            catch (Exception e)
            {
                model.status = 999;
            }
            return model;
        }
    }
}
