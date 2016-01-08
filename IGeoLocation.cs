using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geocoding.Net
{
    interface IGeoLocation
    {
        /// <summary>
        /// 根据经纬度反编译出位置信息
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        Location GeoLocationByLngLat(Point point);
    }
}
