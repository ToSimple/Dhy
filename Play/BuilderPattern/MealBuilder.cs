using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Play.BuilderPattern
{
    public class MealBuilder
    {
        public Meal prepareVegMeal()
        {
            Meal meal = new Meal();
            meal.AddCoffe(new CaffeAmericano());
            meal.AddCoffe(new Latte());
            return meal;
        }

        public Meal prepareNonVegMeal()
        {
            Meal meal = new Meal();
            meal.AddCoffe(new LatteeAmericano());
            meal.AddCoffe(new Cappuccino());
            return meal;
        }
    }
}
