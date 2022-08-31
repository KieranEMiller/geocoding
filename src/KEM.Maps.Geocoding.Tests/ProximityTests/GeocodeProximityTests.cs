using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KEM.Maps.Geocoding.Tests.ProximityTests
{
    [TestFixture]
    internal class GeocodeProximityTests
    {
        [Test]
        public void same_coordinates_returns_0_distance()
        {
            var coord1 = new Coordinate(KnownCoordinates.NEWARK_PENN_STATION_NJ_USA.Latitude, KnownCoordinates.NEWARK_PENN_STATION_NJ_USA.Longitude);
            var coord2 = new Coordinate(KnownCoordinates.NEWARK_PENN_STATION_NJ_USA.Latitude, KnownCoordinates.NEWARK_PENN_STATION_NJ_USA.Longitude);
            var coord3 = new Coordinate(KnownCoordinates.NEWARK_PENN_STATION_NJ_USA.Latitude, KnownCoordinates.NEWARK_PENN_STATION_NJ_USA.Longitude);

            var results = new Geocoding.Proximity.GeocodeProximity().CalculateProximityMatrix(
                new List<IGeolocatableByCoordinates>() { coord1, coord2, coord3 }
            );

            Assert.That(results.Count, Is.EqualTo(0));
        }
    }
}
