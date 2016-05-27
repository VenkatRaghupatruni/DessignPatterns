using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DessignPatterns
{
    /* The observer  pattern is a Behavioural design pattern as it defines a manner for controlling communication between classes or entities.
       It defines a link between objects so that when one object's state changes, all dependent objects 
       are updated automatically. This pattern allows communication between objects in a loosely coupled manner*/

    class ObserverClient
    {
        static void Main(string[] args)
        {
            EventReceiver receiver = new EventReceiver();
            EventMonitor emailer = new EventEmailer(receiver);
            receiver.Attach(emailer);
            EventMonitor logger = new EventLogger(receiver);
            receiver.Attach(logger);

            receiver.LogMessage("Message with two observers.");

            Console.Read();
        }
    }
}
