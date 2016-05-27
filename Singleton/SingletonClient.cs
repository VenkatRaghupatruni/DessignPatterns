using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Singleton
{
    /* The singleton pattern is a creational design pattern that is used to ensure that a class can only have one concurrent instance. 
     Whenever additional objects of a singleton class are required, the previously created, single instance is provided. */

    class SingletonClient
    {
        static void Main(string[] args)
        {
            ApplicationState state = ApplicationState.GetState();
            state.LoginId = "BlackWasp";
            state.MaxSize = 1024;

            ApplicationState state2 = ApplicationState.GetState();
            Console.WriteLine(state2.LoginId);      // Outputs "BlackWasp"
            Console.WriteLine(state2.MaxSize);      // Outputs "1024"
            Console.WriteLine(state == state2);     // returns true

            Console.ReadLine();
        }
    }
}
