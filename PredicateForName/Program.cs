using System;
using System.Linq;
using System.Collections.Generic;

namespace PredicateForName
{
    class Program
    {
        static void Main(string[] args)
        {
            var nameLenght = int.Parse(Console.ReadLine());
            var listOfNames = Console.ReadLine().Split();
            //
           IEnumerable<string> selectedName = ChechLenghtOfName(nameLenght, listOfNames);
            Console.WriteLine(string.Join("\n", selectedName));
        }

        private static IEnumerable<string> ChechLenghtOfName(int nameLenght, string[] listOfNames)
        {
            Func<string, bool> checker = n => n.Length <= nameLenght;

            var selectedName = listOfNames.Where(checker);
            return selectedName;
        }
    }
}
