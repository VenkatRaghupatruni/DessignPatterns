using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade
{
    /* Facade is a structural pattern as it defines a manner for creating relationships between classes or entities. 
      It is used to define a simplified interface to a more complex subsystem. */

    class FacadeClient
    {
        static void Main(string[] args)
        {
            StockFacade facade = new StockFacade();
            bool low = facade.IsLowStock("ABC123");
            Console.WriteLine(low);

            Console.Read();
        }
    }
}
