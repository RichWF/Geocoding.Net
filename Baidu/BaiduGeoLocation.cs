using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geocoding.Net.Baidu
{
    class BaiduGeoLocation : IGeoLocation
    {
        /// <summary>
        /// 根据经纬度反编译出位置信息
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        public override Location GeoLocationByLngLat(Point point)
        {
            BaiduLocation bdLocation = BaiduLocations.GetBaiduLocationByLngLat(point);
            if (bdLocation.status == 999)
                return null;
            else
            {
                addressComponent address = bdLocation.result.addressComponent;
                Location location = new Location(
                    address.city,
                    address.country,
                    address.district,
                    address.province,
                    address.street,
                    address.street_number,
                    address.country_code
                    );
                return location;
            }
        }
    }
}
