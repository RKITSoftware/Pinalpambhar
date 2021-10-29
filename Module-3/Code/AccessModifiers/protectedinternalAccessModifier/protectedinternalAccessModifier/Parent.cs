using System;
using System.Collections.Generic;
using System.Text;

namespace protectedinternalAccessMod
{
    public class Parent
    {

        // Declaring member as protected internal
        protected internal int value;
    }

    class ABC
    {

        // Trying to access
        // value in another class
        public void testAccess()
        {
            // Member value is Accessible
            Parent obj1 = new Parent();
            obj1.value = 12;
        }
    }
}
