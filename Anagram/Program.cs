using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    class Program
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT */
        private static IList<string> wordInputs = new List<string>();
        private static IList<string> anagrams = new List<string>();

        static void Main(string[] args)
        {
            string word = string.Empty;
            while ((word = Console.ReadLine()) != "-1")
            {
                wordInputs.Add(word);
            }

            FindAnagrams();
            PrintResults();
            Console.ReadKey();
        }

        private static void PrintResults()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var anagram in anagrams)
            {
                sb.AppendLine(anagram);
            }

            Console.WriteLine(sb.ToString());
        }

        private static void FindAnagrams()
        {
            foreach (var word in wordInputs)
            {
                SearchAnagramFor(word, wordInputs.IndexOf(word));
            }
        }

        private static void SearchAnagramFor(string word, int idx)
        {
            var actualSorted = Sort(word).Trim();
            var anagram = string.Empty;

            foreach (var comp in wordInputs)
            {
                if (wordInputs.IndexOf(comp) != idx)
                {
                    var compWordSorted = Sort(comp).Trim();

                    if (actualSorted.Equals(compWordSorted) && !Exists(comp))
                    {
                        if (string.IsNullOrEmpty(anagram))
                        {
                            anagram = string.Format("{0}, {1}", word, comp);
                        }
                        else
                        {
                            anagram = string.Format("{0}, {1}", anagram, comp);
                        }
                    }
                }
            }

            if (!string.IsNullOrEmpty(anagram))
            {
                anagrams.Add(anagram);
            }
        }

        private static bool Exists(string comp)
        {
            foreach (var anagram in anagrams)
            {
                if (anagram.Contains(comp))
                    return true;
            }
            return false;
        }

        private static string Sort(string input)
        {
            var chars = input.ToCharArray();
            Array.Sort(chars);
            return new string(chars);
        }
    }
}