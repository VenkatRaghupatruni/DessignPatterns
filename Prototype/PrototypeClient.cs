using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototype
{
    /* The prototype design pattern is a design pattern that is used to instantiate a class by copying, or cloning, the properties of an existing object.
       The new object is an exact copy of the prototype but permits modification without altering the original. */

    class PrototypeClient
    {
        static void Main(string[] args)
        {
            Developer dev = new Developer();
            dev.Name = "Bob";
            dev.Role = "Team Leader";
            dev.PreferredLanguage = "C#";

            Developer devCopy = (Developer)dev.Clone();
            devCopy.Name = "Sue";

            Console.WriteLine(dev);
            Console.WriteLine(devCopy);

            /* OUTPUT
 
            Bob - Team Leader - C#
            Sue - Team Leader - C#
 
            */

            Typist typist = new Typist();
            typist.Name = "Kay";
            typist.Role = "Typist";
            typist.WordsPerMinute = 120;

            Typist typistCopy = (Typist)typist.Clone();
            typistCopy.Name = "Tim";
            typistCopy.WordsPerMinute = 115;

            Console.WriteLine(typist);
            Console.WriteLine(typistCopy);

            /* OUTPUT
 
            Kay - Typist - 120wpm
            Tim - Typist - 115wpm
 
            */

            Console.Read();
        }
    }
}
