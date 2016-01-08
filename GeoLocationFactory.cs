using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geocoding.Net
{
    public class GeoLocationFactory
    {
        /// <summary>
        /// 根据位置类型，实例化对应的编译方式
        /// </summary>
        /// <param name="locationType"></param>
        /// <returns></returns>
        public static IGeoLocation Create(GeoType locationType)
        {
            IGeoLocation geoLocation = null;
            switch (locationType)
            {
                case GeoType.Baidu:
                    geoLocation = new Baidu.BaiduGeoLocation();
                    break;
                case GeoType.Gaode:
                    geoLocation = new Gaode.GaodeGeoLocation();
                    break;
                case GeoType.Google:
                    geoLocation = new Google.GoogleGeoLocation();
                    break;
                default:
                    geoLocation = new Baidu.BaiduGeoLocation();
                    break;
            }
            return geoLocation;
        }
    }
}
