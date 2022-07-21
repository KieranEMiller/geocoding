using KEM.Maps.Geocoding.Services.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace KEM.Maps.Geocoding.Services.Google
{
    public class GoogleMaps : BaseGeocodingService, IGeocodingService
    {
        private const string APP_SETTINGS_GOOGLE_API_KEY = "geocoding-svc-google-api-key";

        public GoogleMaps()
        {
            _apiKey = LoadApiKeyFromConfig();
        }

        public GoogleMaps(IHttpClient httpClient)
            : base(httpClient)
        {
            _apiKey = LoadApiKeyFromConfig();
        }

        private string _apiKey;

        private string LoadApiKeyFromConfig()
        {
            return System.Configuration.ConfigurationManager.AppSettings[APP_SETTINGS_GOOGLE_API_KEY];
        }

        public IGeocodingServiceResult GeocodeByAddress(IGeolocatableByAddress address)
        {
            var urlBuilder = new GoogleRequestUrlBuilder(_apiKey);

            string addressAsString = $"{address.Street1}, {address.City}, {address.State}, {address.Zip}";
            var url = urlBuilder.Build(addressAsString);

            string result = _httpClient.IssueGetRequest(url);
            var responseParser = new GoogleResponseParser();

            return responseParser.Parse(result);
        }

        public IGeocodingServiceResult GeocodeByCoordinates(IGeolocatableByCoordinates coords)
        {
            throw new NotImplementedException();
        }
    }
}
