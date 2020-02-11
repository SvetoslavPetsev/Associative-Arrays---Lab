using System;
using System.Linq;
using System.Collections.Generic;

namespace _05._Word_Filter
{
    class Program
    {
        static void Main()
        {
            string[] arr = Console.ReadLine().Split();

            string[] sortedArr = arr.Where(x => x.Length % 2 == 0).ToArray();

            Console.WriteLine(string.Join(Environment.NewLine, sortedArr));
        }
    }
}
