using System;
using System.Collections.Generic;
using System.Linq;

namespace Inferno
{
    class Program
    {
        static void Main(string[] args)
        {
            var gems = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            ExecuteCommands(gems);
            Console.WriteLine(string.Join(" ", gems));
        }

        private static void ExecuteCommands(List<int> gems)
        {
            var input = Console.ReadLine().Split(new char[] { ';'});
            var exclusionFilters = new Queue<KeyValuePair<string, int>>();

            while (input[0] != "Forge")
            {
                var command = input[0];
                var filterType = input[1];
                var filterParamenter = int.Parse(input[2]);

                switch (command)
                {
                    case "Exclude":
                        exclusionFilters.Enqueue(new KeyValuePair<string, int>(filterType, filterParamenter));
                        break;
                    case "Reverse":
                        if (exclusionFilters.Count > 0)
                        {
                            exclusionFilters.Dequeue();
                        }
                        break;

                    default:
                        break;
                }
                input = Console.ReadLine().Split(new char[] { ';' });
            }
            ExecuteExclusion(gems, exclusionFilters);
        }

        private static void ExecuteExclusion(List<int> gems, Queue<KeyValuePair<string, int>> exclusionFilters)
        {
            foreach (var filter in exclusionFilters.Reverse())
            {
                switch (filter.Key)
                {
                    case "Sum Left":
                        FilterLeft(filter.Value, gems);
                        break;
                    case "Sum Right":
                        FilterRight(filter.Value, gems);
                        break;
                    case "Sum Left Right":
                        FilterLeftRight(filter.Value, gems);
                        break;
                    default:
                        break;
                }
            }
        }

        private static void FilterRight(int value, List<int> gems)
        {

            while (gems.Count> 0 && gems.Last()==value)
            {
                gems.RemoveAt(gems.Count-1);
            }
            for (int i = 0; i < gems.Count; i++)
            {
                var right = i == gems.Count - 1 ? gems[i + 1] : 0;
                if (right + gems[i] == value)
                {
                    gems.RemoveAt(i);
                    i--;
                }

            }
        }

        private static void FilterLeft(int value, List<int> gems)
        {
            while (gems.Count > 0 && gems.First() == value)
            {
                gems.RemoveAt(0);
            }

            for (int i = gems.Count - 1; i >= 0; i--)
            {
                var left = i > 0 ? gems[i - 1] : 0;
                if (left + gems[i] == value)
                {
                    gems.RemoveAt(i);
                }
            }
        }

        private static void FilterLeftRight(int value, List<int> gems)
        {
            for (int i = 0; i < gems.Count; i++)
            {
                var left = i == 0 ? 0 : gems[i - 1];
                var right = i == gems.Count - 1 ? gems[i + 1] : 0;
                if (left+right+gems[i] == value)
                {
                    gems.RemoveAt(i);
                    i--;
                }
            }
        }
    }
}
