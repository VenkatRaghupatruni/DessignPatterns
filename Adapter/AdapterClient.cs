using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter
{
    /* Adapter is a structural pattern as it defines a manner for creating relationships between classes. It is used to provide a link between 
       two otherwise incompatible types by wrapping the "adaptee" with a class that supports the interface required by the client. */

    class AdapterClient
    {
        static void Main(string[] args)
        {
            PersonnelSystem personnel = new PersonnelSystem();
            PhoneListAdapter adapter = new PhoneListAdapter(personnel);
            Intranet intranet = new Intranet(adapter);
            intranet.ShowPhoneList();

            Console.Read();
        }
    }
}
