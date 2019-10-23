using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bookmi.Controllers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bookmi.Controllers.Tests
{
    [TestClass()]
    public class HomeControllerTests
    {
        [TestMethod()]
        public void Index_ReturnsViewResults()
        {
            HomeController home = new HomeController();

            var result = home.Index();

            Assert.IsNotNull(result);
        }
    }
}