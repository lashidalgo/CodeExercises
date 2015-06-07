using System;
using System.Collections.Generic;
using System.Linq;

namespace CountingSort2
{
    class Program
    {
        static void Main(string[] args)
        {
            var numElements = int.Parse(Console.ReadLine());
            int[] res = new int[100];

            foreach (int i in Console.ReadLine().Trim().Split(' ').Select(int.Parse))
            {
                res[i]++;
            }

            for (int index = 0; index < res.Length; index++)
            {
                for (int i = 0; i < res[index]; i++)
                {
                    Console.Write("{0} ", index);
                }
            }
        }
    }
}
