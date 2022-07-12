using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KEM.Maps.Geocoding.Services.Google
{
    public class GoogleConstants
    {
        public const string GEOCODING_ENDPOINT = "https://maps.googleapis.com/maps/api/geocode/xml";

        public class Xml
        {
            public const string ELEMENT_NAME_RESPONSE = "GeocodeResponse";
            public const string ELEMENT_NAME_RESULT = "result";
            public const string ELEMENT_NAME_GEOMETRY = "geometry";
            public const string ELEMENT_NAME_LOCATION = "location";
            public const string ELEMENT_NAME_LATITUDE = "lat";
            public const string ELEMENT_NAME_LONGITUDE = "lng";
        }
    }
}
