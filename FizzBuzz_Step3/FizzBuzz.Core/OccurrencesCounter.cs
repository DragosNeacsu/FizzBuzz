using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz.Core
{
    public class OccurrencesCounter
    {
        private static List<string> _itemsToReport = new List<string> { "fizz", "buzz", "fizzbuzz", "lucky", "integer" };
        private readonly Dictionary<string, int> _report;
        private int _totalItems;
        public OccurrencesCounter()
        {
            _report = new Dictionary<string, int>();
        }
        public void Add(string item)
        {
            _totalItems++;
            if (_itemsToReport.Contains(item))
            {
                if (!_report.ContainsKey(item))
                {
                    _report.Add(item, 1);
                }
                else
                {
                    _report[item]++;
                }
            }
        }

        public Dictionary<string, int> GetReport()
        {
            return _report;
        }

        public int CountIntegers()
        {
            return _totalItems - _report.Where(x => _itemsToReport.Contains(x.Key)).Sum(x => x.Value);
        }
    }
}
