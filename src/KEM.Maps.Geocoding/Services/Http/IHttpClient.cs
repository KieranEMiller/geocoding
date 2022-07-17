using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KEM.Maps.Geocoding.Services.Http
{
    public interface IHttpClient
    {
        string IssueGetRequest(string uri);
    }
}
