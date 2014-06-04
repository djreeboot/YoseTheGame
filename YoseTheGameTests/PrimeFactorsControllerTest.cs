using System;
using System.Collections.Generic;
using System.Web.Mvc;
using NUnit.Framework;
using YoseTheGame.Controllers;
using YoseTheGame.Models;

namespace YoseTheGameTests
{
    [TestFixture]
    public class PrimeFactorsControllerTest
    {
        private ActionResult _result;

        [SetUp]
        public void ThisController()
        {
            var controller = new PrimeFactorsController();
            _result = controller.Index("2");
        }

        [Test]
        public void ReturnsJson()
        {
            Assert.That(_result, Is.InstanceOf<JsonResult>());
        }
    }
}
