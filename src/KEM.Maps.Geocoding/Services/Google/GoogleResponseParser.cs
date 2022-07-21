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
        public IGeocodingServiceResult Parse(string response)
        {
            var xml = XDocument.Parse(response);
            var xmlEleResponse =  xml.Element(GoogleConstants.Xml.ELEMENT_NAME_RESPONSE);
            if (xmlEleResponse == null)
                throw new ArgumentException($"response did not contain expected element {GoogleConstants.Xml.ELEMENT_NAME_RESPONSE}", GoogleConstants.Xml.ELEMENT_NAME_RESPONSE);

            XElement locationElement = xmlEleResponse
                .Element(GoogleConstants.Xml.ELEMENT_NAME_RESULT)
                .Element(GoogleConstants.Xml.ELEMENT_NAME_GEOMETRY)
                .Element(GoogleConstants.Xml.ELEMENT_NAME_LOCATION);

            return new Geocoding.Coordinate()
            {
                Latitude = TryExtractCoordinateComponent(locationElement, GoogleConstants.Xml.ELEMENT_NAME_LATITUDE),
                Longitude = TryExtractCoordinateComponent(locationElement, GoogleConstants.Xml.ELEMENT_NAME_LONGITUDE)
            };
        }

        private double TryExtractCoordinateComponent(XElement locationElement, string coordinateComponentName)
        {
            XElement xmlElement = locationElement.Element(coordinateComponentName);
            if (xmlElement == null)
                throw new ArgumentException($"failed to locate location element {coordinateComponentName} from response");

            double coordinateVal;
            if (!double.TryParse(xmlElement.Value, out coordinateVal))
                throw new ArgumentException($"failed to parse coordinate component {coordinateComponentName} from response", coordinateComponentName);
            return coordinateVal;
        }
    }
}
