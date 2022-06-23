using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorytm1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = args[0];
            List<string> words = new List<string>();
            string actualWord = "";
            int howMany = 1;

            for (int i = 0; i < word.Length; i++)
            {
                actualWord = word.Substring(i, 1);
                words.Add(actualWord);
                for (int j = i + howMany; j < word.Length; j++)
                {
                    actualWord += word[j];
                    words.Add(actualWord);
                    if (j == word.Length - 1)
                    {
                        howMany++;
                        j = i + howMany - 1;
                        if (j > word.Length) break;
                        actualWord = word.Substring(i, 1);
                        continue;
                    }
                }
                howMany = 1;
            }
            words = words.OrderBy(a => a.Length).ToList();
            
            foreach (var w in words)
            {
                Console.WriteLine(w);
            }
        }
    }
}
