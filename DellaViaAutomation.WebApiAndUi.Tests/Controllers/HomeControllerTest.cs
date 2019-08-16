using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DellaViaAutomation.WebApiAndUi;
using DellaViaAutomation.WebApiAndUi.Controllers;

namespace DellaViaAutomation.WebApiAndUi.Tests.Controllers
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
            Assert.AreEqual("Home Page", result.ViewBag.Title);
        }
    }
}
