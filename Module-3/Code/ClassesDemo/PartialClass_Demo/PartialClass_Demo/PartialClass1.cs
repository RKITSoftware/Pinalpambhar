using System;
using System.Collections.Generic;
using System.Text;

namespace PartialClass_Demo
{
    public partial class PartialClass
    {
        /* Here, FirstName and LastName are member of partialClass
         from PartialClass file */

        public void FullName()
        {
            Console.WriteLine("Full Name:" + FirstName + " " + LastName);
        }
    }
}
