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

            return this.Latitude == other.Latitude && this.Longitude == other.Longitude;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(this.Latitude, this.Longitude);
        }

        bool IEquatable<IGeolocatableByCoordinates>.Equals(IGeolocatableByCoordinates other)
        {
            if (other == null) return false;

            return this.Latitude == other.Latitude && this.Longitude == other.Longitude;
        }
    }
}
