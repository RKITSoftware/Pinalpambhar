using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass_demo
{
    public abstract class Customer
    {
        private string _firstName;
        private string _lastName;

        //get and  is used return variable's value 
        //set is used to assign a value to variable

        #region Property : _firstName
        public string FirstName
        {
            get
            {
                return _firstName;
            }

            set
            {
                _firstName = value;
            }
        }
        #endregion Property : _firstName

        #region Property : _lastName
        public string LastName
        {
            get
            {
                return _lastName;
            }

            set
            {
                _lastName = value;
            }
        }
        #endregion Property : _lastName

       //Abstract Method FullName
        public abstract void FullName();
    }
}
