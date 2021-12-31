using System.Collections.Generic;
using System.Linq;
using WebApi_HttpVerbs.Models;

namespace WebApi_HttpVerbs.Controllers
{
    public class People
    {
        List<Person> people = new List<Person>();
        public People()
        {
            
            people.Add(new Person { FirstName = "Tim", LastName = "Corey", Id = 1 });
            people.Add(new Person { FirstName = "Sue", LastName = "Strom", Id = 2 });
            people.Add(new Person { FirstName = "Bilbo", LastName = "Beggins", Id = 3 });
        }

        public List<Person> GetCompleteList()
        {
            return people;
        }

        public Person GetListByID(int id)
        {
            return people.Where(x => x.Id == id).FirstOrDefault();
           
        }

        public void AddItem(Person val)
        {
            people.Add(val);
        }

        public void RemoveItem(int id)
        {
            people.Remove(people.Where(x => x.Id == id).FirstOrDefault());
        }

        public void EditItem(int id,Person val)
        {
            people[id] = val;
        }
    }
}