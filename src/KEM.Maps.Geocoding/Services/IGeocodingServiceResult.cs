using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KEM.Maps.Geocoding.Services
{
    public interface IGeocodingServiceResult
    {
        double Latitude { get; set; }

        double Longitude { get; set; }
    }
}
