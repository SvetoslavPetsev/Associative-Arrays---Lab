using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Odd_Occurrences
{
    class Program
    {
        static void Main()
        {
            string[] someElements = Console.ReadLine().Split();

            Dictionary<string, int> oddElement = new Dictionary<string, int>();

            foreach (string element in someElements)
            {
                string curr = element.ToLower();
                if (oddElement.ContainsKey(curr))
                {
                    oddElement[curr]++;
                }
                else
                {
                    oddElement.Add(curr, 1);
                }
            }

            foreach (var element in oddElement)
            {
                if (element.Value % 2 != 0)
                {
                    Console.Write(element.Key + " ");
                }
            }

        }
    }
}
