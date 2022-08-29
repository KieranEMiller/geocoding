using KEM.Maps.Geocoding.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KEM.Maps.Geocoding
{
    public class Coordinate : 
        IGeocodingServiceResult, 
        IGeolocatableByCoordinates,
        IEquatable<Coordinate>
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

        public bool Equals(Coordinate other)
        {
            if (other == null) return false;

            if (this.Latitude == other.Latitude && this.Longitude == other.Longitude)
                return true;

            return false;
        }

        public override int GetHashCode()
        {
            return this.Longitude.GetHashCode() + this.Latitude.GetHashCode();
        }
    }
}
