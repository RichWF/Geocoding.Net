using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geocoding.Net.Google
{
    class GoogleGeoLocation : IGeoLocation
    {
        /// <summary>
        /// 根据经纬度反编译出位置信息
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        public override Location GeoLocationByLngLat(Point point)
        {
            return null;
        }

        public override Point GeoPointByLocation(string location)
        {
            return base.GeoPointByLocation(location);
        }
    }
}
