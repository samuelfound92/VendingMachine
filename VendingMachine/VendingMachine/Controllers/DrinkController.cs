using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VendingMachine.Models;
using VendingMachine.Data;

namespace VendingMachine.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DrinkController : ControllerBase
    {
        private readonly IDrinkRepo _drinkRepo;

        public DrinkController(IDrinkRepo drinkRepo) 
        {
            _drinkRepo = drinkRepo;
        }
        
        [HttpGet]
        public ActionResult<IEnumerable<DrinkOption>> GetAllDrinkOptions()
        {
            var drinks = _drinkRepo.GetDrinkOptions();
            return Ok(drinks);
        }

        //GET api/drinks/{id}
        [HttpGet("{id}")]
        public ActionResult<Drink> GetDrink(int id)
        {
            var drinkToReturn = _drinkRepo.GetDrink(id);

            if (drinkToReturn != default(Drink))
            {
                return Ok(drinkToReturn);
            }
            else 
            {
                return NotFound();
            }
        }
    }
}
