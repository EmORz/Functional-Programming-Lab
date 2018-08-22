using System;
using System.Collections.Generic;
using System.Linq;

namespace AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse);
                

            var commands = Console.ReadLine();

            while (commands !="end")
            {
                switch (commands)
                {
                    case "add":
                        numbers = ForEach(numbers, x => x+1);
                        break;
                    case "multiply":
                        numbers = ForEach(numbers, x => x * 2);
                        break;
                    case "subtract":
                        numbers = ForEach(numbers, x => x-1);
                        break;
                    case "print":
                        Console.WriteLine(string.Join(" ", numbers));
                        break;
                }
                commands = Console.ReadLine();
            }


        }
        public static IEnumerable<int> ForEach(IEnumerable<int> collect, Func<int, int> func)
        {
            return collect.Select(x => func(x));
        }
    }
}
