using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KEM.Maps.Geocoding.Services.Google
{
    public class GoogleRequestUrlBuilder
    {
        public GoogleRequestUrlBuilder(string apiKey)
        {
            _apiKey = apiKey;
        }

        private string _apiKey;

        public string Build(string address)
        {
            StringBuilder url = new StringBuilder(GoogleConstants.GEOCODING_ENDPOINT);

            if (GoogleConstants.GEOCODING_ENDPOINT.EndsWith("?") == false)
                url.Append("?");

            url.Append(AppendKeyValuePair("key", _apiKey));
            url.Append(AppendKeyValuePair("sensor", "false"));
            url.Append(AppendKeyValuePair("address", address));

            return url.ToString();
        }

        private string AppendKeyValuePair(string key, string value)
        {
            return $"{key}={value}";
        }
    }
}
