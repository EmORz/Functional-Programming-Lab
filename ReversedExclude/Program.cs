using System;
using System.Linq;

namespace ReversedExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            var divisionNum = int.Parse(Console.ReadLine());

            //
            Func<int, bool> checker = x => x % divisionNum != 0;
            var remind = numbers.Where(checker);
            var reverse = remind.Reverse();
            Console.WriteLine(string.Join(" ", reverse));

        }
    }
}
