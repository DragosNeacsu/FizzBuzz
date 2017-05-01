using System.Text;

namespace FizzBuzz.Core
{
    public class Generator
    {
        private readonly IRules _rules;

        public Generator(IRules rules)
        {
            _rules = rules;
        }
        public string Generate(int number)
        {
            var result = new StringBuilder();

            if (_rules.ContainsThree(number))
            {
                return "lucky";
            }

            if (number % 3 == 0)
            {
                result.Append("fizz");
            }
            if (number % 5 == 0)
            {
                result.Append("buzz");
            }
            if (result.Length == 0)
            {
                result.Append(number.ToString());
            }
            return result.ToString();
        }
    }
}
