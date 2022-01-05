using System.Collections.Generic;
using System.Linq;
using WebApi_HttpVerbs.Models;

namespace WebApi_HttpVerbs.Controllers
{
    public class BLPeople
    {
        //Creating List of Person type
        List<Person> people = new List<Person>();

        /// <summary>
        /// BLPeople() constructor without parameters
        /// it is used to add items to the list.
        /// </summary>
        public BLPeople()
        {

            people.Add(new Person { FirstName = "Tim", LastName = "Corey", Id = 1 });
            people.Add(new Person { FirstName = "Sue", LastName = "Strom", Id = 2 });
            people.Add(new Person { FirstName = "Bilbo", LastName = "Beggins", Id = 3 });
        }

        /// <summary>
        /// GetCompleteList() method return List person
        /// with all it's items
        /// </summary>
        /// <returns>List of type person</returns>
        public List<Person> GetCompleteList()
        {
            return people;
        }

        /// <summary>
        /// getListById(int id) method 
        /// match id given by user with list item
        /// if id found in the list then it will return that person object
        /// </summary>
        /// <param name="id">id is unique identity number for each person</param>
        /// <returns>return Person object</returns>
        public Person GetListByID(int id)
        {
            return people.Where(x => x.Id == id).FirstOrDefault();

        }

        /// <summary>
        /// AddItem(Person val)
        /// method add item to list person
        /// </summary>
        /// <param name="val">val is object type of person 
        /// which contains FirstName, LastName & Id of person
        /// </param>
        public void AddItem(Person val)
        {
            people.Add(val);
        }

        /// <summary>
        /// RemoveItem(int id)
        /// method remove item from the list
        /// whose id matches to the id given by user
        /// </summary>
        /// <param name="id">id is unique identity number for each person</param>
        public void RemoveItem(int id)
        {
            people.Remove(people.Where(x => x.Id == id).FirstOrDefault());
        }

        /// <summary>
        /// EditItem(int id, Person val)
        /// method edit FirstName, LastName of person based on it's Id
        /// </summary>
        /// <param name="id">id is unique identity number for each person</param>
        /// <param name="val">
        /// val is object type of person 
        /// which contains FirstName, LastName & Id of person
        /// </param>
        public void EditItem(int id, Person val)
        {
            people[id] = val;
        }
    }
}