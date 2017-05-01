using FizzBuzz.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz
{
    class Program
    {
        static void Main()
        {
            var output = new StringBuilder();
            var generator = new Generator(new Rules());
            var counter = new OccurrencesCounter();

            for (int i = 1; i <= 20; i++)
            {
                var result = generator.Generate(i);
                output.Append($"{result} ");
                counter.Add(result);
            }

            output.Append("\n");
            foreach (KeyValuePair<string, int> item in counter.GetReport())
            {
                output.Append($"{item.Key} {item.Value}\n");
            }
            output.Append($"integers {counter.CountIntegers()}\n");

            Console.Write(output.ToString());
        }
    }
}
