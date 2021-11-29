using FirstWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FirstWebAPI.Controllers
{
    /// <summary>
    /// This will give you all information about person
    /// </summary>
    public class PeopleController : ApiController
    {
        List<Person> people = new List<Person>()    ;

        /*
         * PeopleController is constructor
         * which is used to assign values to list people
         */
        public PeopleController()
        {
            people.Add(new Person { FirstName = "Pinal", LastName = "Pambhar", Id = 1 });
            people.Add(new Person { FirstName = "Krupali", LastName = "Lalkiya", Id = 2 });
            people.Add(new Person { FirstName = "Dhanshree", LastName = "Patel", Id = 3 });
        }

        /// <summary>
        /// GetfirstNames method return firstname of all person.
        /// </summary>
        /// <returns></returns>

        [Route("api/people/getfirstnames")]
        [HttpGet]
        public List<string> GetFirstName() 
        {
            List<string> output = new List<string>();

            foreach(var p in people)
            {
                output.Add(p.FirstName);
            }
            return output;
        }

        // GET: api/People
        public List<Person> Get()
        {
            return people;
        }

        // GET: api/People/5
        public Person Get(int id)
        {
            return people.Where(x => x.Id == id).FirstOrDefault();
        }

        // POST: api/People
        public void Post([FromBody] Person value)
        {
            people.Add(value);
        }
    }
}
