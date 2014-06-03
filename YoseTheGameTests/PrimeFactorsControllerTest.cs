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

        [Test]
        public void ReturnsJsonWithNumber()
        {
            PrimeFactorsModel pfm = (PrimeFactorsModel)((JsonResult)_result).Data;
            Assert.That(pfm.number, Is.EqualTo(2));
        }

        [Test]
        public void ReturnsJsonWithValidDecomposition()
        {
            PrimeFactorsModel pfm = (PrimeFactorsModel)((JsonResult)_result).Data;
            Assert.That(pfm.decomposition, Is.EqualTo(new List<int>{2}));
        }
    }
}
