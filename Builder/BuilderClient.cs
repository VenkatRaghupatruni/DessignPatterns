using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder
{
    /* The builder pattern is a creational design pattern that allows for the step-by-step creation of complex objects using the correct sequence of actions. 
       The construction is controlled by a director object that only needs to know the type of object it is to create. */

    class BuilderClient
    {
        static void Main(string[] args)
        {
            MealDirector director = new MealDirector();
            MealBuilder jvmb = new JollyVegetarianMealBuilder();
            director.MakeMeal(jvmb);
            Meal vegMeal = jvmb.GetMeal();
            Console.WriteLine(vegMeal);
            Console.WriteLine();

            MealBuilder mmmb = new MischievousMexicanMealBuilder();
            director.MakeMeal(mmmb);
            Meal mexMeal = mmmb.GetMeal();
            Console.WriteLine(mexMeal);

            Console.Read();
        }
    }
}
