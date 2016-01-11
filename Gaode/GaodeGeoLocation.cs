using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geocoding.Net.Gaode
{
    class GaodeGeoLocation : IGeoLocation
    {
        /// <summary>
        /// 根据经纬度反编译出位置信息
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        public override Location GeoLocationByLngLat(Point point)
        {
            GaodeLocation gdlocation = GaodeLocations.GetGaodeLocationByLngLat(point);
            if (gdlocation.status == "999")
                return null;
            else
            {
                AddressComponent address = gdlocation.regeocode.addressComponent;
                Location location = new Location(
                    gdlocation.regeocode.formatted_address,
                    address.city,
                    "中国",
                    address.district,
                    address.province,
                    address.township,
                    address.adcode
                    );
                return location;
            }

        }
    }
}
