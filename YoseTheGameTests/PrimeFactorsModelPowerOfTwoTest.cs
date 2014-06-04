using System.Collections.Generic;
using NUnit.Framework;
using YoseTheGame.Models;

namespace YoseTheGameTests
{
    [TestFixture]
    public class PrimeFactorsModelPowerOfTwoTest
    {
        private NumberResponse response = null;

        [SetUp]
        public void ThisModel()
        {
            PrimeFactorsModel model = new PrimeFactorsModel();
            response = (NumberResponse)model.Decompose("16");
        }

        [Test]
        public void ReturnsSpecifiedNumber()
        {
            Assert.That(response.number, Is.EqualTo(16));
        }

        [Test]
        public void ReturnsValidDecomposition()
        {
            Assert.That(response.decomposition, Is.EqualTo(new List<int> { 2, 2, 2, 2 }));
        }
    }
}
