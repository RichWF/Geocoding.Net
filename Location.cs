using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geocoding.Net
{
    class Location
    {
        /// <summary>
        /// 城市
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// 国家
        /// </summary>
        public string Country { get; set; }
        /// <summary>
        /// 区/县
        /// </summary>
        public string District { get; set; }
        /// <summary>
        /// 省份
        /// </summary>
        public string Province { get; set; }
        /// <summary>
        /// 街道
        /// </summary>
        public string Street { get; set; }
        /// <summary>
        /// 街道号码
        /// </summary>
        public string StreetNumber { get; set; }
        /// <summary>
        /// 地区编码
        /// </summary>
        public int CountryCode { get; set; }
    }
}
