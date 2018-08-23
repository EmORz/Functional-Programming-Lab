using System;
using System.Collections.Generic;
using System.Linq;

namespace PredicateParty
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfPeoples = Console.ReadLine().Split().ToList();

            Comands(listOfPeoples);
            PrintData(listOfPeoples);

        }

        private static void PrintData(List<string> listOfPeoples)
        {
            if (listOfPeoples.Any())
            {
                var temp = string.Join(", ", listOfPeoples);
                Console.WriteLine(temp+ " are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }

        private static void Comands(List<string> listOfPeoples)
        {
            var command = Console.ReadLine().Split().ToList();

            while (command[0] != "Party!")
            {
                switch (command[1])
                {
                    case "StartsWith":
                        ForEach(command[0], listOfPeoples, n => n.StartsWith(command[2]));
                        break;
                    case "EndsWith":
                        ForEach(command[0], listOfPeoples, n => n.EndsWith(command[2]));
                        break;
                    case "Length":
                        ForEach(command[0], listOfPeoples, n =>n.Length == int.Parse(command[2]));
                        break;
                    default:
                        break;
                }
                command = Console.ReadLine().Split().ToList();
            }

        }

        private static void ForEach(string command, List<string> listOfPeoples, Func<string, bool> condition)
        {
            for (int i = listOfPeoples.Count - 1; i >= 0; i--)
            {
                if (condition(listOfPeoples[i]))
                {
                    switch (command)
                    {
                        case "Remove":
                            listOfPeoples.RemoveAt(i);
                            break;
                        case "Double":
                            listOfPeoples.Add(listOfPeoples[i]);
                            break;
                        default:
                            break;
                    }
                }
            }

        }
    }
}
