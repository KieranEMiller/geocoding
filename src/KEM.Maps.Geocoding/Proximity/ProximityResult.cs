using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KEM.Maps.Geocoding.Proximity
{
    public class ProximityResult
    {
        public double DistanceInMeters { get; set; }

        public IGeolocatableByCoordinates From { get; set; }

        public IGeolocatableByCoordinates To { get; set; }
    }
}
