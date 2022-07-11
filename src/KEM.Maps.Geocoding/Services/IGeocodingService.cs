using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KEM.Maps.Geocoding.Services
{
    public interface IGeocodingService
    {
        IGeocodingServiceResult GeocodeByAddress(IGeolocatableByAddress address);

        IGeocodingServiceResult GeocodeByCoordinates(IGeolocatableByCoordinates coords);
    }
}
