using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KEM.Maps.Geocoding.Data
{
    interface IGeocodingDataSource
    {
        IList<T> LoadFromPath<T>(string path) 
            where T: class, new();
    }
}
