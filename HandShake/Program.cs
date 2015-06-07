using System;
using System.Collections.Generic;

namespace HandShake
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfDiretors = new List<int>();
            for (var i = int.Parse(Console.ReadLine()) - 1; i >= 0; i--)
            {
                var num = int.Parse(Console.ReadLine());
                numberOfDiretors.Add((num * (num - 1)) / 2);
            }

            numberOfDiretors.ForEach(Console.WriteLine);
        }
    }
}
