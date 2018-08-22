using System;
using System.Collections.Generic;
using System.Linq;

namespace FindEvenOrOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var start = numbers[0];
            var end = numbers[1];
            var command = Console.ReadLine().Trim().ToLower();

            Predicate<int> checkEvenOrOdd;

            checkEvenOrOdd = Checker(command);
            PrintNumCollection(start, end, checkEvenOrOdd);

        }

        private static Predicate<int> Checker(string command)
        {
            Predicate<int> checkEvenOrOdd;
            switch (command)
            {
                case "odd":
                    checkEvenOrOdd = n => n % 2 != 0;
                    break;
                case "even":
                    checkEvenOrOdd = n => n % 2 == 0;
                    break;
                default:
                    checkEvenOrOdd = null;
                    break;
            }

            return checkEvenOrOdd;
        }

        private static void PrintNumCollection(int start, int end, Predicate<int> checkEvenOrOdd)
        {
            List<int> collectData = new List<int>();

            for (int i = start; i <= end; i++)
            {
                if (checkEvenOrOdd(i))
                {
                    collectData.Add(i);
                }
            }

            Console.WriteLine(string.Join(" ", collectData));
        }
    }
}
