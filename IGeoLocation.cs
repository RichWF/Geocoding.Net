using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geocoding.Net
{
    public abstract class IGeoLocation
    {
        /// <summary>
        /// 根据经纬度反编译出位置信息
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        public virtual Location GeoLocationByLngLat(Point point)
        {
            return null;
        }

        /// <summary>
        /// 根据位置信息编译出经纬度
        /// </summary>
        /// <param name="location"></param>
        /// <returns></returns>
        public virtual Point GeoPointByLocation(string location)
        {
            return null;
        }
    }
}
