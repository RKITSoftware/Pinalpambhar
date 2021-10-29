using System;
using System.Collections.Generic;
using System.Text;
using internalAccessModifier;


namespace xyz
{
    class internalModifier
    {
        // Will give an error during compilation
        Complex c1 = new Complex();
        c1.setData(2, 3);
    }
}
