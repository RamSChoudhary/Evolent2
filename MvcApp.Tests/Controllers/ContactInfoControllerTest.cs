using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcApp.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace MvcApp.Tests.Controllers
{
    [TestClass]
    public class ContactInfoControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            ContactInfoController controller = new ContactInfoController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull("ContactInfo Index Controller Test", result.ViewBag.Message);
        }

        [TestMethod]
        public void Create()
        {
            // Arrange
            ContactInfoController controller = new ContactInfoController();

            // Act
            ViewResult result = controller.Create() as ViewResult;

            // Assert
            Assert.IsNotNull("ContactInfo Create Controller Test", result.ViewBag.Message);
        }

        [TestMethod]
        public void Edit(int id)
        {
            // Arrange
            ContactInfoController controller = new ContactInfoController();

            // Act
            ViewResult result = controller.Edit(id) as ViewResult;

            // Assert
            Assert.IsNotNull("ContactInfo Create Controller Test", result.ViewBag.Message);
        }
    }
}
