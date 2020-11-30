using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendingMachine.Data;
using VendingMachine.Models;
using VendingMachine.Controllers;
using Moq;
using Microsoft.AspNetCore.Mvc;

namespace VendingMachine.Tests
{
    [TestClass]
    public class DrinkControllerTests
    {
        private static Mock<IDrinkRepo> _drinkRepo;
        private static DrinkController _drinkController;
        private static int TEST_DRINK_ID = 1;

        [TestInitialize]
        public void SetUp() 
        {
            //Arrange
            _drinkRepo = new Mock<IDrinkRepo>();
            _drinkRepo.Setup(x => x.GetDrink(TEST_DRINK_ID)).Returns( new Drink(TEST_DRINK_ID, "Test Drink", new string[] { "" }));
            _drinkController = new DrinkController(_drinkRepo.Object);
        }

        [TestMethod]
        public void GetAllDrinkOptions_ReturnsOk()
        {
            //Act
            var response = _drinkController.GetAllDrinkOptions();

            //Assert
            Assert.IsInstanceOfType(response.Result, typeof(OkObjectResult));
        }

        [TestMethod]
        public void GetDrink_ForInvalidID_ReturnsNotFound() 
        {
            //Act
            var response = _drinkController.GetDrink(0);

            //Assert
            Assert.IsInstanceOfType(response.Result, typeof(NotFoundResult));
        }

        [TestMethod]
        public void GetDrink_ForValidID_ReturnsOKRequest() 
        {
            //Act
            var response = _drinkController.GetDrink(TEST_DRINK_ID);
            
            //Assert
            Assert.IsInstanceOfType(response.Result, typeof(OkObjectResult));
        }
    }
}
