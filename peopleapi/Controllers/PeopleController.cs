using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using peopleapi.Models;

namespace peopleapi.Controllers
{
    [Route("/")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        /// <summary>
        /// GET The list of people
        /// </summary>
        /// <returns>
        /// HTTP Status showing it was found or that there is an error. And the list of people records.
        /// </returns>
        /// <response code="200">Returns the list of People records</response>
        [HttpGet]
        public ActionResult<IEnumerable<People>> Get()
        {
            List<People> peopleList = new List<People>();
            peopleList.Add(new People() {firstname = "Dale", lastname = "Bingham", title="Mr.", middlename="E."});
            peopleList.Add(new People() {firstname = "Richard", lastname = "Cranium", title="Mr.", middlename="B."});
            peopleList.Add(new People() {firstname = "Christine", lastname = "Smith", title="Ms.", middlename="L."});
            peopleList.Add(new People() {firstname = "Jessica", lastname = "Lampard", title="Mrs.", middlename="Q."});
            return Ok(peopleList);
        }

        /// <summary>
        /// GET a people record
        /// </summary>
        /// <returns>
        /// HTTP Status showing it was found or that there is an error. 
        /// And the the person matching this ID, which we are faking for now. :) 
        /// </returns>
        /// <response code="200">Returns the People record</response>
        [HttpGet("{id}")]
        public ActionResult<People> Get(string id)
        {
            People p = new People();
            p.firstname = "Richard";
            p.middlename = "B";
            p.lastname = "Cranium";
            p.title = "Mr.";
            return Ok(p);
        }

    }
}
