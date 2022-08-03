using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KEM.Maps.Geocoding.Proximity
{
    public class GeocodeProximity
    {
        public IList<ProximityResult> CalculateProximityMatrix(IList<IGeolocatableByCoordinates> inputCoords)
        {
            var results = new List<ProximityResult>();

            foreach(var fromCoord in inputCoords)
            {
                foreach(var toCoord in inputCoords)
                {
                    //TODO: avoid computing distance to itself
                    double distanceInMeters = CalculateDistanceInMeters(fromCoord, toCoord);
                    var proximityResult = new ProximityResult()
                    {
                        From = fromCoord,
                        To = toCoord,
                        DistanceInMeters = distanceInMeters
                    };
                    results.Add(proximityResult);
                }
            }

            return results;
        }

        public double CalculateDistanceInMeters(IGeolocatableByCoordinates from, IGeolocatableByCoordinates to)
        {
            var fromCoord = new GeoCoordinate(from.Latitude, from.Longitude);
            var toCoord = new GeoCoordinate(to.Latitude, to.Longitude);

            double distanceinMeters = fromCoord.GetDistanceTo(toCoord);
            return distanceInMeters;
        }
    }
}
