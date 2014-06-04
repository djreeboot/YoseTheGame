using System;
using System.Collections.Generic;
using System.Web.Mvc;
using NUnit.Framework;
using YoseTheGame.Controllers;
using YoseTheGame.Models;

namespace YoseTheGameTests
{
    [TestFixture]
    public class PrimeFactorsModelStringTest
    {
        private ErrorResponse response = null;

        [SetUp]
        public void ThisModel()
        {
            PrimeFactorsModel model = new PrimeFactorsModel();
            response = (ErrorResponse)model.Decompose("batman");
        }

        [Test]
        public void ReturnsSpecifiedNumber()
        {
            Assert.That(response.number, Is.EqualTo("batman"));
        }

        [Test]
        public void ReturnsExpectedError()
        {
            Assert.That(response.error, Is.EqualTo("not a number"));
        }
    }
}
