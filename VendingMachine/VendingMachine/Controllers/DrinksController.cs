using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VendingMachine.Models;

namespace VendingMachine.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DrinksController : ControllerBase
    {
        private static Drink[] Drinks = new[]
        {
            new Drink()
            { 
                ID = 1,
                Name = "Lemon Tea",
                Steps = new string[]{ "Boil some water", "Steep the water in the tea", "Pour tea in the cup", "Add lemon" }
            },
            new Drink(){ 
                ID = 2,
                Name = "Coffee",
                Steps = new string[]{ "Boil some water", "Brew the coffee grounds", "Pour coffee in the cup", "Add sugar and milk" }
            },
            new Drink(){ 
                ID = 3,
                Name = "Chocolate",
                Steps = new string[]{ "Boil some water", "Add drinking chocolate powder to the water", "Pour chocolate in the cup" }
            }
        };

        [HttpGet]
        public ActionResult<IEnumerable<Drink>> Get()
        {
            return Ok(Drinks);
        }

        [HttpGet]
        public ActionResult<Drink> Get(int Id)
        {
            var drinkToReturn = Drinks.FirstOrDefault(x => x.ID == Id);

            if (drinkToReturn != default(Drink))
            {
                return Ok(drinkToReturn);
            }
            else 
            {
                return BadRequest("Invalid drink selection");
            }
        }
    }
}
