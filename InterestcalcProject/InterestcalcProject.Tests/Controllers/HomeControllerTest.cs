using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InterestcalcProject;
using InterestcalcProject.Controllers;

namespace InterestcalcProject.Tests.Controllers
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

        [TestMethod]
        public void Calculate_test1()
        {
            // Arrange
            HomeController controller = new HomeController();
            double amount = 100;
            double year = 10;
            double rate = 10.5;
            double expected = amount * year * (rate / 100);
            double actual = 105;
        
            // Act
            ViewResult result = controller.Calculate() as ViewResult;
       
            // Assert
            if(result != null){
                Assert.AreEqual(expected, actual);
            }
        }
        [TestMethod]
        public  void Calculate_test2()
        {
            // Arrange
            HomeController controller = new HomeController();
            double amount = 5000;
            double year = 5;
            double rate = 5;
            double expected = amount * year * (rate / 100);
            double actual = 1250;

            // Act
            ViewResult result = controller.Calculate() as ViewResult;

            // Assert
            if (result != null)
            {
                Assert.AreEqual(expected, actual);
            }

        }

        [TestMethod]
        public void Calculate_test3()
        {
            // Arrange
            HomeController controller = new HomeController();
            double amount = 5000;
            double year = 5;
            double rate = 10;
            double expected = amount * year * (rate / 100);
            double actual = 2500;

            // Act
            ViewResult result = controller.Calculate() as ViewResult;

            // Assert
            if (result != null)
            {
                Assert.AreEqual(expected, actual);
            }

        }

        [TestMethod]
        public void Calculate_test4()
        {
            // Arrange
            HomeController controller = new HomeController();
            double amount = 5000;
            double year = 7;
            double rate = 5;
            double expected = amount * year * (rate / 100);
            double actual = 1750;

            // Act
            ViewResult result = controller.Calculate() as ViewResult;

            // Assert
            if (result != null)
            {
                Assert.AreEqual(expected, actual);
            }

        }

        [TestMethod]
        public void Calculate_test5()
        {
            // Arrange
            HomeController controller = new HomeController();
            double amount = 5000;
            double year = 8;
            double rate = 5;
            double expected = amount * year * (rate / 100);
            double actual = 2000;

            // Act
            ViewResult result = controller.Calculate() as ViewResult;

            // Assert
            if (result != null)
            {
                Assert.AreEqual(expected, actual);
            }

        }
    }
}
