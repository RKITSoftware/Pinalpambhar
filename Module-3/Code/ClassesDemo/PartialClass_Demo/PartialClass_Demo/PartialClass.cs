using System;
using System.Collections.Generic;
using System.Text;

namespace PartialClass_Demo
{
    public partial class PartialClass
    {
        private string _firstName;
        private string _lastName;

        #region Property: FirstName
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
        #endregion Property: FirstName

        #region Property: LastName
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
        #endregion Property: LastName
    }
}
