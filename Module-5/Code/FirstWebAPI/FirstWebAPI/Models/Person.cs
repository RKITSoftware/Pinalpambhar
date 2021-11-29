using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstWebAPI.Models
{
    /// <summary>
    /// Represents one specific person.
    /// </summary>
    public class Person
    {
        /// <summary>
        /// id is unique identification for individual person
        /// </summary>
        public int Id { get; set; } = 0;

        /// <summary>
        /// FirstName is user's firstName
        /// </summary>
        public string FirstName { get; set; } = "";

        /// <summary>
        /// LastName is user's LastName
        /// </summary>
        public string LastName { get; set; } = "";
    }
}