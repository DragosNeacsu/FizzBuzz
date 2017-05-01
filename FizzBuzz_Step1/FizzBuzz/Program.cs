using FizzBuzz.Core;
using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main()
        {
            var generator = new Generator();

            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine(generator.Generate(i));
            }
        }
    }
}
