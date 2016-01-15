using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geocoding.Net.Gaode
{
    public class GaodePoint
    {
        public string status { get; set; }

        public string info { get; set; }

        public string infocode { get; set; }

        public string count { get; set; }

        public List<GaodeGeocode> geocodes { get; set; }
    }

    public class GaodeGeocode
    {
        public string formatted_address { get; set; }

        public string province { get; set; }

        public string citycode { get; set; }

        public string city { get; set; }

        public string district { get; set; }

        public string adcode { get; set; }

        public string street { get; set; }

        public string number { get; set; }

        public string location { get; set; }

        public string level { get; set; }
    }
}
