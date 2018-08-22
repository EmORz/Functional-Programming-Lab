using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var numbers = Console.ReadLine().Split().Select(int.Parse).Distinct().ToList();
            //
            var predicates = numbers.Select(x => (Func<int, bool>)(n => n % x == 0)).ToArray();
            var data = new List<int>();
            for (int i = 1; i <= num; i++)
            {
                if (IsValid(predicates, i))
                {
                    data.Add(i);
                }
            }
            Console.WriteLine(string.Join(" ", data));

        }

        private static bool IsValid(Func<int, bool>[] predicates, int i)
        {
            foreach (var item in predicates)
            {
                if (!item(i))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
