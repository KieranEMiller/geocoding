﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace KEM.Maps.Geocoding.Services
{
    public class GoogleMaps : IGeocodingService
    {
        public Coordinates Run(Address address, string apiKey)
        {
            string addr = $"{address.Street1}, {address.City}, {address.State}, {address.Zip}";
            var coords = GetLatLng(addr);
            return coords;
        }

        public Coordinates GetLatLng(string address)
        {
            string requestUri = string.Format("https://maps.googleapis.com/maps/api/geocode/xml?key={1}&address={0}&sensor=false", Uri.EscapeDataString(address), API_KEY);
            var client = new HttpClient();
            client.PostAsync
            WebRequest request = WebRequest.Create(requestUri);
            WebResponse response = request.GetResponse();
            XDocument xdoc = XDocument.Load(response.GetResponseStream());

            XElement result = xdoc.Element("GeocodeResponse").Element("result");
            XElement locationElement = result.Element("geometry").Element("location");
            XElement lat = locationElement.Element("lat");
            XElement lng = locationElement.Element("lng");

            var coords = new LatLng(decimal.Parse(lat.Value), decimal.Parse(lng.Value));

            return coords;
        }

        public IGeocodingServiceResult GeocodeByAddress(IGeolocatableByAddress address)
        {
            throw new NotImplementedException();
        }

        public IGeocodingServiceResult GeocodeByCoordinates(IGeolocatableByCoordinates coords)
        {
            throw new NotImplementedException();
        }

        private 
    }
}
