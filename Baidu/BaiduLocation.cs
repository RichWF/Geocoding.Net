using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geocoding.Net.Baidu
{
    public class BaiduLocation
    {
        /// <summary>
        /// 状态 ，999为自定义异常信息
        /// </summary>
        public int status { get; set; }

        public result result { get; set; }
    }

    public class result
    {
        public location location { get; set; }

        public string formatted_address { get; set; }

        public string business { get; set; }

        public addressComponent addressComponent { get; set; }

        public List<pois> pois { get; set; }

        // public poiRegions poiRegions { get; set; }

        public string sematic_description { get; set; }

        public int cityCode { get; set; }
    }

    public class location
    {
        public double lng { get; set; }

        public double lat { get; set; }
    }

    public class addressComponent
    {
        public string city { get; set; }

        public string country { get; set; }

        public string direction { get; set; }

        public string distance { get; set; }

        public string district { get; set; }

        public string province { get; set; }

        public string street { get; set; }

        public string street_number { get; set; }

        public int country_code { get; set; }
    }

    public class pois
    {
        public string addr { get; set; }

        public string cp { get; set; }

        public string direction { get; set; }

        public string distance { get; set; }

        public string name { get; set; }

        public string poiType { get; set; }

        public point point { get; set; }

        public string tag { get; set; }

        public string tel { get; set; }

        public string uid { get; set; }

        public string zip { get; set; }
    }

    public class point
    {
        public float x { get; set; }
        public float y { get; set; }
    }

    public class poiRegions
    { }
}
