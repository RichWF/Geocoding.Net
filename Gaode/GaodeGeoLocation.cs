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
            if (gdlocation.status != "0")
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
        /// <summary>
        /// 根据位置信息编译出经纬度
        /// </summary>
        /// <param name="location"></param>
        /// <returns></returns>
        public override Point GeoPointByLocation(string location)
        {
            GaodePoint gdPoint = GaodePoints.GetGaodeLngLatByLocation(location);
            if (gdPoint.status != "0")
                return null;
            else
            {
                GaodeGeocode gdGeoCode = gdPoint.geocodes[0];
                string[] points = gdGeoCode.location.Split(',');
                Point point = new Point(Convert.ToDouble(points[0]), Convert.ToDouble(points[1]));
                return point;
            }
        }
    }
}
