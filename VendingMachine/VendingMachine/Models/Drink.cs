using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VendingMachine.Models
{
    public class DrinkOption
    {
        public int ID { get; set; }
        public string Name { get; set; }        
    }

    public class Drink : DrinkOption 
    {
        public string[] Steps { get; set; }
    }

}
