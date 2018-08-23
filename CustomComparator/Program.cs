using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomComparator
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            var odd = new List<int>();
            var even = new List<int>();

            foreach (var num in numbers)
            {
                if (num % 2 == 0)
                {
                    even.Add(num);
                }
                else
                {
                    odd.Add(num);
                }
            }
            even.Sort();
            odd.Sort();
            var fullLine = even.Concat(odd);
            Console.WriteLine(string.Join(" ", fullLine));
        }
    }
}
