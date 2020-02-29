using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace FlightsApp.Models
{
    public class Flight
    {
        string price;
        string airlines;
        string route;
        static List<Flight> flightList = new List<Flight>();

        public Flight(string price, string airlines, string flyFrom, string to, string route)
        {
            this.price = price;
            this.airlines = airlines;
            this.route = route;
        }

        public string Price { get => price; set => price= value; }
        public string Airlines { get => airlines; set => airlines = value; }
        public string Route { get => route; set => route = value; }

        public static List<Flight> FlightList { get => flightList; set => flightList = value; }


    }

}
