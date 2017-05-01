using System.Text;

namespace FizzBuzz.Core
{
    public class Generator
    {
        public string Generate(int number)
        {
            var result = new StringBuilder();
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
