using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geocoding.Net
{
    public class Point
    {
        /// <summary>
        /// 经度
        /// </summary>
        double longitude;
        /// <summary>
        /// 纬度
        /// </summary>
        double latitude;

        public virtual double Longitude
        {
            get { return longitude; }
            set
            {
                longitude = value;
            }
        }

        public virtual double Latitude
        {
            get { return latitude; }
            set
            {
                latitude = value;
            }
        }

        public Point() : this(0, 0) { }

        public Point(double lng, double lat)
        {
            this.Longitude = lng;
            this.Latitude = lat;
        }
    }
}
