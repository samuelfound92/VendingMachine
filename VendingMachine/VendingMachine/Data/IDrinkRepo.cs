using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendingMachine.Models;

namespace VendingMachine.Data
{
    public interface IDrinkRepo
    {
        public IEnumerable<DrinkOption> GetDrinkOptions();
        public Drink GetDrink(int id);
    }
}
