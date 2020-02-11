using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Largest_3_Numbers
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] sortedNum = numbers.OrderByDescending(x => x).ToArray();

            if (sortedNum.Length > 2)
            {
                Console.WriteLine(string.Join(" ", sortedNum.Take(3)));
            }
            else
            {
                Console.WriteLine(string.Join(" ", sortedNum));
            }
            
        }
    }
}
