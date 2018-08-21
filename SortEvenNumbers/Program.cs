using System;
using System.Linq;

namespace SortEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputNumbers = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Console.WriteLine(string.Join(", ", inputNumbers.Where(x => x % 2 == 0).OrderBy(x => x)));
        }
    }
}
