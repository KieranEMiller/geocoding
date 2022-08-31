using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KEM.Maps.Geocoding
{
    public class Address : IGeolocatableByAddress, IGeolocatableByCoordinates
    {
        public string Id { get; set; }

        public string Street1 { get; set; }

        public string Street2 { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Zip { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }

        bool IEquatable<IGeolocatableByCoordinates>.Equals(IGeolocatableByCoordinates other)
        {
            if (other == null) return false;

            return this.Latitude == other.Latitude && this.Longitude == other.Longitude;
        }
    }
}
