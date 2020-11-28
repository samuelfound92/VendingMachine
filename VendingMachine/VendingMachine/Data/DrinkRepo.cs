using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendingMachine.Models;

namespace VendingMachine.Data
{
    public class DrinkRepo : IDrinkRepo
    {
        private static Drink[] Drinks = new[]
        {
            new Drink(
                1,
                "Lemon Tea",
                new string[]{ "Boil some water", "Steep the water in the tea", "Pour tea in the cup", "Add lemon" }
            ),
            new Drink(
                2,
                "Coffee",
                new string[]{ "Boil some water", "Brew the coffee grounds", "Pour coffee in the cup", "Add sugar and milk" }
            ),
            new Drink(
                3,
                "Chocolate",
                new string[]{ "Boil some water", "Add drinking chocolate powder to the water", "Pour chocolate in the cup" }
            )
        };

        public Drink GetDrink(int id)
        {
            return Drinks.FirstOrDefault(x => x.ID == id);
        }

        public IEnumerable<DrinkOption> GetDrinkOptions()
        {
            return Drinks;
        }
    }
}
