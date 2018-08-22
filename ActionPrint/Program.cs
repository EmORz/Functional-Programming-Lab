using System;

namespace ActionPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            Action<string[]> data = Print;
            data(input);
        }

        private static void Print(string[] obj)
        {
            Console.WriteLine(string.Join("\n", obj));
        }
    }
}
