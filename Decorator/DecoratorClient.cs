using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    /* Decorator is a structural pattern as it defines a manner for creating relationships between classes or entities. 
       It is used to extend or alter the functionality of objects at run-time by wrapping them in an object of a decorator class. 
       This provides a flexible alternative to using inheritance to modify behaviour.*/
    
    class DecoratorClient
    {
        static void Main(string[] args)
        {
            // Basic vehicle
            Ferrari360 car = new Ferrari360();

            Console.WriteLine("Base price is {0:c} for {1} laps.", car.HirePrice, car.HireLaps);

            // Special offer
            SpecialOffer offer = new SpecialOffer(car);
            offer.DiscountPercentage = 25;
            offer.ExtraLaps = 2;

            Console.WriteLine("Offer price is {0:c} for {1} laps.", offer.HirePrice, offer.HireLaps);

            // Hire for basic vehicle
            Hireable hire1 = new Hireable(car);
            hire1.Hire("Bob");

            // Hire for vehicle with special offer
            Hireable hire2 = new Hireable(offer);
            hire2.Hire("Bill");

            Console.Read();
        }
    }
}
