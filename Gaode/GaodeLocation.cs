using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geocoding.Net.Gaode
{
    /// <summary>
    /// 位置信息Model
    /// </summary>
   public class GaodeLocation
    {
        public string status { get; set; }

        public string info { get; set; }

        public string infocode { get; set; }

        public Regeocode regeocode { get; set; }
    }

    public class Regeocode
    {
        /// <summary>
        /// 结构化地址信息
        /// </summary>
        public string formatted_address { get; set; }

        public AddressComponent addressComponent { get; set; }
    }

    public class AddressComponent
    {
        /// <summary>
        /// 省份
        /// </summary>
        public string province { get; set; }
        /// <summary>
        /// 市
        /// </summary>
        public string city { get; set; }
        /// <summary>
        /// 市code
        /// </summary>
        public string citycode { get; set; }
        /// <summary>
        /// 地区
        /// </summary>
        public string district { get; set; }
        /// <summary>
        /// 街道号码
        /// </summary>
        public string adcode { get; set; }
        /// <summary>
        /// 街道
        /// </summary>
        public string township { get; set; }

        //public Neighborhood neighborhood { get; set; }

        //public Building building { get; set; }

        //public StreetNumber streetNumber { get; set; }

        //public List<BusinessAreas> businessAreas { get; set; }
    }

    public class Neighborhood
    {
        public string[] name { get; set; }

        public string[] type { get; set; }
    }

    public class Building
    {
        public string[] name { get; set; }

        public string[] type { get; set; }
    }

    public class StreetNumber
    {
        public string[] street { get; set; }

        public string[] number { get; set; }

        public string[] direction { get; set; }

        public string[] distance { get; set; }
    }

    public class BusinessAreas
    {
        public string location { get; set; }

        public string name { get; set; }

        public string id { get; set; }
    }
}
