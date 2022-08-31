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
            var alreadyComputed = new HashSet<int>();

            foreach(var fromCoord in inputCoords)
            {
                foreach(var toCoord in inputCoords)
                {
                    //don't calculate proximity to itself
                    if (fromCoord.Equals(toCoord)) continue;

                    //don't calculate if this pair of coordinates has already been computed
                    int coordinatesHash = HashCode.Combine(fromCoord.GetHashCode(), toCoord.GetHashCode());
                    if(alreadyComputed.Contains(coordinatesHash)) continue;

                    double distanceInMeters = CalculateDistanceInMeters(fromCoord, toCoord);
                    var proximityResult = new ProximityResult()
                    {
                        From = fromCoord,
                        To = toCoord,
                        DistanceInMeters = distanceInMeters
                    };
                    results.Add(proximityResult);
                    alreadyComputed.Add(coordinatesHash);
                }
            }

            return results;
        }

        public double CalculateDistanceInMeters(IGeolocatableByCoordinates from, IGeolocatableByCoordinates to)
        {
            var fromCoord = new GeoCoordinate(from.Latitude, from.Longitude);
            var toCoord = new GeoCoordinate(to.Latitude, to.Longitude);

            double distanceInMeters = fromCoord.GetDistanceTo(toCoord);
            return distanceInMeters;
        }
    }
}
