﻿using System;
using System.Collections.Generic;
using System.Web.Mvc;
using NUnit.Framework;
using YoseTheGame.Controllers;
using YoseTheGame.Models;

namespace YoseTheGameTests
{
    [TestFixture]
    public class PrimeFactorsModelPrimesTest
    {
        private NumberResponse response = null;

        [SetUp]
        public void ThisModel()
        {
            PrimeFactorsModel model = new PrimeFactorsModel();
            response = (NumberResponse)model.Decompose("4916");
        }

        [Test]
        public void ReturnsSpecifiedNumber()
        {
            Assert.That(response.number, Is.EqualTo(4916));
        }

        [Test]
        public void ReturnsValidDecomposition()
        {
            Assert.That(response.decomposition, Is.EqualTo(new List<int> { 2, 2, 1229 }));
        }
    }
}
