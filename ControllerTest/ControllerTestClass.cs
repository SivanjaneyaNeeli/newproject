using DevOpsSampleWebApp.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Web.Mvc;

namespace ControllerTest
{
    [TestClass]
    public class ControllerTestClass
    {
        [TestMethod]
        public void Login()
        {
            // Arrange
            HomeController controller = new HomeController();
            // Act
            ViewResult result = controller.Login() as ViewResult;
            // Assert
            Assert.AreEqual("Login",result.ViewName);

        }

        [TestMethod]
        public void About()
        {
            // Arrange
            HomeController controller = new HomeController();
            // Act
            ViewResult result = controller.About() as ViewResult;
            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [TestMethod]
        public void Contact()
        {
            // Arrange
            HomeController controller = new HomeController();
            // Act
            ViewResult result = controller.Contact() as ViewResult;
            // Assert
            Assert.IsNotNull(result);
        }
    }
}