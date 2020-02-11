using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Count_Real_Numbers

{
    class Program
    {
        static void Main()
        {
            double[] someNumbers = Console
                .ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            SortedDictionary<double, int> someDictionary = new SortedDictionary<double, int>();
            

            foreach (double number in someNumbers)
            {
                if (someDictionary.ContainsKey(number))
                {
                    someDictionary[number]++;
                }

                else
                {
                    someDictionary.Add(number, 1);
                }

            }

            foreach (var number in someDictionary)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
    }
}
