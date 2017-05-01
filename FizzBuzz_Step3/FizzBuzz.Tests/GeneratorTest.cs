using FizzBuzz.Core;
using NSubstitute;
using NUnit.Framework;

namespace FizzBuzz.Tests
{
    public class GeneratorTest
    {
        private Generator _generator;
        private IRules _rules;

        [SetUp]
        public void SetUp()
        {
            _rules = Substitute.For<IRules>();
            _generator = new Generator(_rules);
        }

        [Test]
        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(3)]
        public void Generate_AnyNumber_ShouldReturnNotEmptyString(int number)
        {
            var result = _generator.Generate(number);

            Assert.IsNotEmpty(result);
        }

        [Test]
        [TestCase(-1)]
        [TestCase(1)]
        [TestCase(2)]
        public void Generate_NotMultipleOf3Or5_ShouldReturnTheNumber(int number)
        {
            var result = _generator.Generate(number);

            Assert.AreEqual(number.ToString(), result);
        }

        [Test]
        [TestCase(-3)]
        [TestCase(3)]
        [TestCase(6)]
        public void Generate_MultipleOf3_ShouldReturnFizz(int number)
        {
            var result = _generator.Generate(number);

            Assert.AreEqual("fizz", result);
        }

        [Test]
        [TestCase(-5)]
        [TestCase(5)]
        [TestCase(10)]
        public void Generate_MultipleOf5_ShouldReturnBuzz(int number)
        {
            var result = _generator.Generate(number);

            Assert.AreEqual("buzz", result);
        }

        [Test]
        [TestCase(-15)]
        [TestCase(15)]
        [TestCase(30)]
        public void Generate_MultipleOf3And5_ShouldReturnFizzBuzz(int number)
        {
            var result = _generator.Generate(number);

            Assert.AreEqual("fizzbuzz", result);
        }

        [Test]
        [TestCase(-3)]
        [TestCase(1)]
        [TestCase(3)]
        [TestCase(5)]
        [TestCase(15)]
        public void Generate_AnyNumber_ShouldCallRuleOverride(int number)
        {
            var result = _generator.Generate(number);

            _rules.Received(1).ContainsThree(number);
        }


        [Test]
        [TestCase(-3)]
        [TestCase(13)]
        [TestCase(30)]
        public void Generate_ContainsThree_ShouldReturnLucky(int number)
        {
            _rules.ContainsThree(number).Returns(true);

            var result = _generator.Generate(number);

            Assert.AreEqual("lucky", result);
        }
    }
}
