using System;
using System.Linq;

namespace AddVat
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] prices = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();

            var pricesWithVAT = prices.Select(x => x * 0.2+x);

            Console.WriteLine(string.Join($"\n", pricesWithVAT.Select(p => $"{p:f2}")));
        }
    }
}
