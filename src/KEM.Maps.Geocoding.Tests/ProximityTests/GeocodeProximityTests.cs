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
        public void same_coordinates_returns_no_proximity_results()
        {
            var coord1 = new Coordinate(KnownCoordinates.NEWARK_PENN_STATION_NJ_USA.Latitude, KnownCoordinates.NEWARK_PENN_STATION_NJ_USA.Longitude);
            var coord2 = new Coordinate(KnownCoordinates.NEWARK_PENN_STATION_NJ_USA.Latitude, KnownCoordinates.NEWARK_PENN_STATION_NJ_USA.Longitude);
            var coord3 = new Coordinate(KnownCoordinates.NEWARK_PENN_STATION_NJ_USA.Latitude, KnownCoordinates.NEWARK_PENN_STATION_NJ_USA.Longitude);

            var results = new Geocoding.Proximity.GeocodeProximity().CalculateProximityMatrix(
                new List<IGeolocatableByCoordinates>() { coord1, coord2, coord3 }
            );

            Assert.That(results.Count, Is.EqualTo(0));
        }

        [Test]
        public void empty_coords_list_returns_no_results()
        {
            var results = new Geocoding.Proximity.GeocodeProximity().CalculateProximityMatrix(
                new List<IGeolocatableByCoordinates>() {}
            );

            Assert.That(results.Count, Is.EqualTo(0));
        }

        [Test]
        public void null_coords_list_returns_no_results()
        {
            var results = new Geocoding.Proximity.GeocodeProximity().CalculateProximityMatrix(
                null
            );

            Assert.That(results.Count, Is.EqualTo(0));
        }
    }
}
