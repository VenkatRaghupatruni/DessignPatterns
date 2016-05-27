using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder
{
    public class MealDirector
    {
        public void MakeMeal(MealBuilder mealBuilder)
        {
            mealBuilder.AddSandwich();
            mealBuilder.AddSideOrder();
            mealBuilder.AddDrink();
            mealBuilder.AddOfferItem();
            mealBuilder.SetPrice();
        }

    }
}
