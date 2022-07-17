using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace KEM.Maps.Geocoding.Services.Http
{
    public class HttpClientWrapper : IHttpClient
    {
        public string IssueGetRequest(string uri)
        {
            WebRequest request = WebRequest.Create(uri);
            request.Method = WebRequestMethods.Http.Get;

            using (WebResponse response = request.GetResponse())
            {
                using (Stream webResponse = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(webResponse);
                    string result = reader.ReadToEnd();
                    return result;
                }
            }
        }
    }
}
