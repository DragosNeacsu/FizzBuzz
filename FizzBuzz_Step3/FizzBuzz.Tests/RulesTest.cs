using FizzBuzz.Core;
using NUnit.Framework;

namespace FizzBuzz.Tests
{
    public class RulesTest
    {
        private Rules _rules;

        [SetUp]
        public void SetUp()
        {
            _rules = new Rules();
        }

        [Test]
        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(1)]
        public void ContainsThree_AnyNumber_ShouldReturnFalse(int number)
        {
            var result = _rules.ContainsThree(number);

            Assert.False(result);
        }

        [Test]
        [TestCase(-3)]
        [TestCase(33)]
        [TestCase(134)]
        public void ContainsThree_NumberContains3_ShouldReturnTrue(int number)
        {
            var result = _rules.ContainsThree(number);

            Assert.IsTrue(result);
        }
    }
}
