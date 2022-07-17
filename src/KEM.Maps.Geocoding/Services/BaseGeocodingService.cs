using KEM.Maps.Geocoding.Services.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KEM.Maps.Geocoding.Services
{
    public class BaseGeocodingService
    {
        public BaseGeocodingService()
            : this(new HttpClientWrapper())
        { }

        public BaseGeocodingService(IHttpClient client)
        {
            _httpClient = client;
        }

        private IHttpClient _httpClient;
    }
}
