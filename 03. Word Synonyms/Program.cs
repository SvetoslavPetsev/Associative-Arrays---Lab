using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Word_Synonyms
{
    class Program
    {
        static void Main()
        {
            int numberWords = int.Parse(Console.ReadLine());
        

            Dictionary<string, List<string>> synonyms = new Dictionary<string, List<string>>();

            for (int i = 0; i < numberWords; i++)
            {
                string wordKey = Console.ReadLine();
                string wordSyno = Console.ReadLine();

                if (!synonyms.ContainsKey(wordKey))
                {
                    synonyms.Add(wordKey, new List<string>());
                }
                if (synonyms.ContainsKey(wordKey))
                {
                    synonyms[wordKey].Add(wordSyno);
                }
            }
            foreach (var word in synonyms)
            {
                Console.WriteLine($"{word.Key} - {string.Join(", ", word.Value)}");
            }
        }
    }
}
