using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory
{
    /*The factory method pattern is a design pattern that allows for the creation of objects without specifying the type of object that is to 
     be created in code. A factory class contains a method that allows determination of the created type at run-time. */

    class FactoryClient
    {
        static void Main(string[] args)
        {
            CarFactory hyundai = new HyundaiCarFactory();
            Car coupe = hyundai.CreateCar("coupe");
            Console.WriteLine(coupe.GetType());

            CarFactory mazda = new MazdaCarFactory();
            Car mx5 = mazda.CreateCar("MX5");
            Console.WriteLine(mx5.GetType()); 

            Console.Read();
        }
    }
}
