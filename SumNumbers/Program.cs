using System;
using System.Linq;

namespace SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputLineNumbers = Console.ReadLine()
                .Split(new[] { ", "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var count = inputLineNumbers.Count();
            var sum = inputLineNumbers.Sum();
            Console.WriteLine(count);

            Console.WriteLine(sum);

        }
    }
}
