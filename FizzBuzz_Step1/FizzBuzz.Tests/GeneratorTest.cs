using FizzBuzz.Core;
using NUnit.Framework;

namespace FizzBuzz.Tests
{
    public class GeneratorTest
    {
        private Generator _generator;

        [SetUp]
        public void SetUp()
        {
            _generator = new Generator();
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
    }
}
