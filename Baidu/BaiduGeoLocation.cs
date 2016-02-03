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
            if (bdLocation != null)
            {
                if (bdLocation.status != 0)
                    return null;
                else
                {
                    addressComponent address = bdLocation.result.addressComponent;
                    Location location = new Location(
                        bdLocation.result.formatted_address,
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
            else
            {
                return null;
            }
        }
        /// <summary>
        /// 根据位置信息编译出经纬度
        /// </summary>
        /// <param name="location"></param>
        /// <returns></returns>
        public override Point GeoPointByLocation(string location)
        {
            BaiduPoint bdPoint = BaiduPoints.GetBaiduLngLatByLocation(location);
            if (bdPoint != null)
            {
                if (bdPoint.status != 0)
                    return null;
                else
                {
                    BaiduPointLocation bdloction = bdPoint.result.location;
                    Point point = new Point(bdloction.lng, bdloction.lat);
                    return point;
                }
            }
            else
            {
                return null;
            }

        }
    }
}
