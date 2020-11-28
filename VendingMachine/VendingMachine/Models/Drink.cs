using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VendingMachine.Models
{
    public class DrinkOption
    {
        public DrinkOption(int id, string name) 
        {
            this.ID = id;
            this.Name = name;
        }

        public int ID { get; set; }
        public string Name { get; set; }        
    }

    public class Drink : DrinkOption 
    {
        public Drink(int id, string name, string[] steps) : base(id, name) 
        {
            this.Steps = steps;
        }
        public string[] Steps { get; set; }
    }

}
