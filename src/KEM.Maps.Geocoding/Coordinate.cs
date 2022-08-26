using KEM.Maps.Geocoding.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KEM.Maps.Geocoding
{
    public class Coordinate : IGeocodingServiceResult
    {
        public Coordinate()
        { }

        public Coordinate(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        public double Latitude { get; set; }

        public double Longitude { get; set; }
    }
}
