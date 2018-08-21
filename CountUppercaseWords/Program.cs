using System;
using System.Linq;

namespace CountUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputText = Console.ReadLine().Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            var check = inputText.Where(x => char.IsUpper(x[0]));

            Console.WriteLine(string.Join("\n", check));



        }
    }
}
