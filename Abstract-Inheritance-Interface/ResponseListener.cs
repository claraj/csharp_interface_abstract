using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Inheritance_Interface
{
    interface ResponseListener
    {
        void ResponseCollected(String response);
        void NoResponseCollected();
    }
}
