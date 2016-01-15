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
        /// <summary>
        /// 位置信息
        /// </summary>
        public location location { get; set; }
        /// <summary>
        /// 结构化地址信息
        /// </summary>
        public string formatted_address { get; set; }
        /// <summary>
        /// 所在商圈信息
        /// </summary>
        public string business { get; set; }
        /// <summary>
        /// 位置信息实体类
        /// </summary>
        public addressComponent addressComponent { get; set; }
        /// <summary>
        /// 附近位置
        /// </summary>
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
        /// <summary>
        /// 城市
        /// </summary>
        public string city { get; set; }
        /// <summary>
        /// 国家
        /// </summary>
        public string country { get; set; }
        /// <summary>
        /// 区县名
        /// </summary>
        public string direction { get; set; }
        /// <summary>
        /// 和当前坐标点的方向，当有门牌号的时候返回数据
        /// </summary>
        public string distance { get; set; }
        /// <summary>
        /// 区县名
        /// </summary>
        public string district { get; set; }
        /// <summary>
        /// 省名
        /// </summary>
        public string province { get; set; }
        /// <summary>
        /// 街道名
        /// </summary>
        public string street { get; set; }
        /// <summary>
        /// 街道门牌号
        /// </summary>
        public string street_number { get; set; }
        /// <summary>
        /// 国家code
        /// </summary>
        public int country_code { get; set; }
    }

    public class pois
    {
        /// <summary>
        /// 地址信息
        /// </summary>
        public string addr { get; set; }
        /// <summary>
        /// 数据来源
        /// </summary>
        public string cp { get; set; }
        /// <summary>
        /// 和当前坐标点的方向
        /// </summary>
        public string direction { get; set; }
        /// <summary>
        /// 离坐标点距离
        /// </summary>
        public string distance { get; set; }
        /// <summary>
        /// poi名称
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// poi类型，如’ 办公大厦,商务大厦’
        /// </summary>
        public string poiType { get; set; }
        /// <summary>
        /// poi坐标{x,y}
        /// </summary>
        public point point { get; set; }

        public string tag { get; set; }
        /// <summary>
        /// 电话
        /// </summary>
        public string tel { get; set; }
        /// <summary>
        /// poi唯一标识
        /// </summary>
        public string uid { get; set; }
        /// <summary>
        /// 邮编
        /// </summary>
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
