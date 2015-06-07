using System;
using System.Collections.Generic;
using System.Linq;

namespace CountingSort
{
    class Solution
    {
        static void Main(String[] args) {
            var numElements = int.Parse(Console.ReadLine());
            var elements = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var repetition = new List<int>();

            for (var i = 0; i < 100; i++)
                repetition.Add(elements.Count(e => e.Equals(i)));

            Console.WriteLine(string.Join(" ",repetition));
        }
    }
}