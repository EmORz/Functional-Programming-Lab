using System;
using System.Linq;

namespace CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Func<int[], int> getMinNum = MinMethod;

            var min = getMinNum(numbers);
            Console.WriteLine(min);
        }

        private static int MinMethod(int[] arg)
        {
            var min = int.MaxValue;

            foreach (var num in arg)
            {
                if (num < min )
                {
                    min = num;
                }
            }
            return min;
            
        }
    }
}
