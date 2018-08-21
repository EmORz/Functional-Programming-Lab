using System;
using System.Collections.Generic;

namespace FilterByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputData = ReadData(); //data collect
            var olderOrYounger = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var format = Console.ReadLine();

            switch (olderOrYounger)
            {
                case "older":
                    foreach (var item in inputData)
                    {
                        if (item.Value>=age)
                        {
                            switch (format)
                            {
                                case "name":
                                    Console.WriteLine(item.Key);
                                    break;
                                case "age":
                                    Console.WriteLine(item.Value);
                                    break;
                                case "name age":
                                    Console.WriteLine($"{item.Key} - {item.Value}");
                                    break;
                            }
                        }
                    }
                    break;
                case "younger":
                    foreach (var item in inputData)
                    {
                        if (item.Value < age)
                        {
                            switch (format)
                            {
                                case "name":
                                    Console.WriteLine(item.Key);
                                    break;
                                case "age":
                                    Console.WriteLine(item.Value);
                                    break;
                                case "name age":
                                    Console.WriteLine($"{item.Key} - {item.Value}");
                                    break;
                            }
                        }
                    }
                    break;
            }
         
        }

        private static Dictionary<string, int> ReadData()
        {
            var n = int.Parse(Console.ReadLine());
            var people = new Dictionary<string, int>(n);
            for (int i = 0; i < n; i++)
            {
                var strData = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                people[strData[0]] = int.Parse(strData[1]);
            }
            return people;
        }
    }
}
