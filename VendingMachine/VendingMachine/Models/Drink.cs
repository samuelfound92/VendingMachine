using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VendingMachine.Models
{
    public class Drink
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string[] Steps { get; set; }
    }

}
