using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KEM.Maps.Geocoding.Services
{
    public interface IHttpWebResponse : IDisposable
    {
        Stream GetReponseStream();
    }
}
