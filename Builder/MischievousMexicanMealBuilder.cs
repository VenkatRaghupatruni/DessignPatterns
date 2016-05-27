using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder
{
    public class MischievousMexicanMealBuilder : MealBuilder
    {
        private Meal _meal = new Meal();

        public override void AddSandwich() { _meal.Sandwich = "Spicy burger"; }
        public override void AddSideOrder() { _meal.SideOrder = "Nachos"; }
        public override void AddDrink() { _meal.Drink = "Tequila"; }
        public override void AddOfferItem() { _meal.Offer = "Hat"; }
        public override void SetPrice() { _meal.Price = 5.49; }
        public override Meal GetMeal() { return _meal; }

    }
}
