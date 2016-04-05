using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Uruit.GameOfDrones;
using Uruit.GameOfDrones.Controllers;

namespace Uruit.GameOfDrones.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Game Of Drones", result.ViewBag.Title);
        }
    }
}
