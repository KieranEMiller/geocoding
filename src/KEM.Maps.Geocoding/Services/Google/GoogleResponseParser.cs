using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace KEM.Maps.Geocoding.Services.Google
{
    public class GoogleResponseParser
    {
        public Coordinates Parse(WebResponse response)
        {
            using (var stream = response.GetResponseStream())
            {
                var xml = XDocument.Load(stream);
                var xmlEleResponse =  xml.Element(GoogleConstants.Xml.ELEMENT_NAME_RESPONSE);
                if(xmlEleResponse == null) 
                    throw new Argument


                    .Element(GoogleConstants.Xml.ELEMENT_NAME_RESULT);

                XElement locationElement = result
                    .Element(GoogleConstants.Xml.ELEMENT_NAME_GEOMETRY)
                    .Element(GoogleConstants.Xml.ELEMENT_NAME_LOCATION);

                XElement lat = locationElement.Element(GoogleConstants.Xml.ELEMENT_NAME_LATITUDE);
                XElement lng = locationElement.Element(GoogleConstants.Xml.ELEMENT_NAME_LONGITUDE);

                double lat = 

                return new Geocoding.Coordinates()
                {
                    Latitude=lat.Value,
                    Longitude=lng
                };
            }
        }

        private double ParseCoord(XElement ele)
        {

        }
    }
}
