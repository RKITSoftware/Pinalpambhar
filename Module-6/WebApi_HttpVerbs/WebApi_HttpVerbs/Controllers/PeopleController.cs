using System.Collections.Generic;
using System.Web.Http;
using WebApi_HttpVerbs.Models;

namespace WebApi_HttpVerbs.Controllers
{
    public class PeopleController : ApiController
    {
        People lstperson = new People();
        // GET: api/People
        public List<Person> Get()
        {          
            List<Person> people = lstperson.GetCompleteList();
            return people;
        }

        // GET: api/People/5
        public Person Get(int id)
        {
            return lstperson.GetListByID(id);
        }

        // POST: api/People
        public void Post(Person value)
        {
            lstperson.AddItem(value);
        }

        // PUT: api/People/5
        public void Put(int id, Person value)
        {
            lstperson.EditItem(id, value);
        }

        // DELETE: api/People/5
        public void Delete(int id)
        {
            lstperson.RemoveItem(id);
        }
    }
}
