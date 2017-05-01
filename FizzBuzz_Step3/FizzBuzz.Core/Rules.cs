namespace FizzBuzz.Core
{
    public class Rules : IRules
    {
        public bool ContainsThree(int number)
        {
            return number.ToString().Contains("3");
        }
    }
}
