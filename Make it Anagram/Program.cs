using System;
using System.Linq;

namespace Make_it_Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var asciiListFirst = Console.ReadLine().ToCharArray();
                var asciiListSecond = Console.ReadLine().ToCharArray();

                var diffs = new int[26];

                foreach (var character in asciiListFirst)
                {
                    diffs[character - 'a']++;
                }

                foreach (var character in asciiListSecond)
                {
                    diffs[character - 'a']--;
                }

                Console.WriteLine(diffs.Sum(diff => Math.Abs(diff)));
            }
        }
    }
}
