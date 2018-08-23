using System;

namespace TreFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var name = Console.ReadLine().Split();
            var total = 0;
            foreach (var namee in name)
            {
                for (int i = 0; i < namee.Length; i++)
                {
                    int asc = Convert.ToInt32(namee[i]);
                    total += asc;
                }
                if (total>num)
                {
                    Console.WriteLine(namee);
                    return;
                }
                total = 0;
            }

        }
    }
}
