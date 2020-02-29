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
       // string FlyFrom;
       // string To;
        string route;
        static List<Flight> flightList = new List<Flight>();

        public Flight(string price, string airlines, string flyFrom, string to, string route)
        {
            this.price = price;
            this.airlines = airlines;
           // this.FlyFrom = flyFrom;
          //  this.To = to;
            this.route = route;
        }

        public string Price { get => price; set => price= value; }
        public string Airlines { get => airlines; set => airlines = value; }
        public string Route { get => route; set => route = value; }

        public static List<Flight> FlightList { get => flightList; set => flightList = value; }
   //     public string FlyFrom1 { get => FlyFrom; set => FlyFrom = value; }

        //public Flight(string _origin, string _destination, string _startdate, string _enddate)
        //{
        //    this.origin = _origin;
        //    this.destination = _destination;
        //    this.startdate = _startdate;
        //    this.enddate = _enddate;
        //}

        //internal static List<Flight> getFlight()
        //{
        //    throw new NotImplementedException();
        //}
    }

}