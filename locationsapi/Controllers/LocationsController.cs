using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using locationsapi.Models;

namespace locationsapi.Controllers
{
    [Route("/")]
    [ApiController]
    public class LocationsController : ControllerBase
    {
        /// <summary>
        /// GET The list of locations
        /// </summary>
        /// <returns>
        /// HTTP Status showing it was found or that there is an error. And the list of location records.
        /// </returns>
        /// <response code="200">Returns the list of location records</response>
        [HttpGet]
        public ActionResult<IEnumerable<Location>> Get()
        {
            List<Location> locationList = new List<Location>();
            locationList.Add(new Location() {name = "My Company", address="987 Luke Skywalker Lane", city="Los Angeles", state="California", zip="53411", phone="333-444-6666", email="dale@mycompany.com"});
            locationList.Add(new Location() {name = "That Other Company", address="1234 Main Street", city="Alexandria", state="Virginia", zip="22112", phone="703-444-6666", email="dale@thatothercompany.com"});
            locationList.Add(new Location() {name = "Hechtinger", address="938447 Locust Drive", city="Annapolis", state="Maryland", zip="53411", phone="333-444-6666", email="dale@hechtinger.com."});
            locationList.Add(new Location() {name = "Woolworths", address="20394 Remember Place", city="Washington", state="District of Columbia", zip="20002", phone="202-444-6666", email="dale@goodluck.com"});
            return Ok(locationList);
        }

        /// <summary>
        /// GET a location record
        /// </summary>
        /// <returns>
        /// HTTP Status showing it was found or that there is an error. 
        /// And the the locations matching this ID, which we are faking for now. :) 
        /// </returns>
        /// <response code="200">Returns the location record</response>
        [HttpGet("{id}")]
        public ActionResult<Location> Get(string id)
        {
            Location loc = new Location();
            loc.name = "Cingulara";
            loc.address = "1234 Main Street";
            loc.city = "Alexandria";
            loc.state = "Virginia";
            loc.zip = "21114";
            loc.email = "me@company.co";
            loc.phone = "800-333-2222";
            loc.web = "https://www.cingulara.com/";
            return Ok(loc);
        }

    }
}
