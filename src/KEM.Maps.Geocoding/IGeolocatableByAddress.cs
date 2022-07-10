using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KEM.Maps.Geocoding
{
    interface IGeolocatableByAddress
    {
        string Street1 { get; set; }

        string Street2 { get; set; }

        string City { get; set; }

        string State { get; set; }

        string Zip { get; set; }
    }
}
