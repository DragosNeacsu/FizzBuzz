using FizzBuzz.Core;
using NUnit.Framework;

namespace FizzBuzz.Tests
{
    public class OccurrencesCounterTest
    {
        private OccurrencesCounter _counter;

        [SetUp]
        public void SetUp()
        {
            _counter = new OccurrencesCounter();
        }

        [Test]
        [TestCase("-1")]
        [TestCase("test")]
        public void Add_ItemNotInReportList_ShouldNotAddToReport(string item)
        {
            _counter.Add(item);

            Assert.AreEqual(0, _counter.GetReport().Count);
        }

        [Test]
        [TestCase("fizz")]
        [TestCase("buzz")]
        [TestCase("fizzbuzz")]
        [TestCase("lucky")]
        public void Add_ItemInReportList_ShouldAddToReport(string item)
        {
            _counter.Add(item);

            Assert.AreEqual(1, _counter.GetReport().Count);
        }

        [Test]
        public void Add_SameItemMultipleTimes_ShouldAppendToExistingReport()
        {
            var item = "fizz";
            int times = 7;

            for (int i = 0; i < times; i++)
            {
                _counter.Add(item);
            }

            Assert.AreEqual(1, _counter.GetReport().Count);
            Assert.AreEqual(times, _counter.GetReport()[item]);
        }

        [Test]
        public void Add_ItemIsDifferentMultipleTimes_ShouldSetTheCorectDictionary()
        {
            for (int i = 0; i < 10; i++)
            {
                _counter.Add("fizz");
                _counter.Add("buzz");
                _counter.Add("fizzbuzz");
                _counter.Add("lucky");
            }

            Assert.AreEqual(4, _counter.GetReport().Count);
        }

        [Test]
        public void GetReport_ShouldReturnDictionary()
        {
            _counter.Add("fizz");

            var result = _counter.GetReport();

            Assert.NotNull(result);
            Assert.AreEqual(1, result.Count);
        }

        [Test]
        public void CountIntegers_ShouldReturnTheTotalNumbersOfIntegers()
        {
            _counter.Add("fizz");
            _counter.Add("1");
            _counter.Add("-2");

            var result = _counter.CountIntegers();

            Assert.NotNull(result);
            Assert.AreEqual(2, result);
        }
    }
}
