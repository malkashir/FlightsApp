﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FlightsApp.Models;

namespace FlightsApp.Controllers
{
    public class FlightController : ApiController
    {
        // GET api/<controller>
        public List<Flight> Get()
        {
            //Flight flight = new Flight();
            return Flight.FlightList;
            return Flight.FlightList;

        }

        ////public List<Flight> Get(int id)
        ////{
        ////    return Flight.FlightList;
        ////}

        // POST api/<controller>
        public void Post([FromBody]Flight flight)
        {
            Flight.FlightList.Add(flight); //add to ist
            //return Flight.flightList;
        }
        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}