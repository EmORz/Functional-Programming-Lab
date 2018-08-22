using System;

namespace KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();

            Action<string[]> dataOfName = Print;
            dataOfName(input);
        }

        private static void Print(string[] obj)
        {
            foreach (var knight in obj)
            {
                var temp = "Sir ";
                Console.WriteLine(temp+knight);
            }
        }
    }
}
