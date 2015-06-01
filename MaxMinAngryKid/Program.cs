using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMinAngryKid
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberElements = Convert.ToInt32(Console.ReadLine());
            var k = Convert.ToInt32(Console.ReadLine()); //number of Unfairness numbers to compare
            var numbers = new List<int>();
            //Read entry
            while (numberElements != 0)
            {
                numbers.Add(Convert.ToInt32(Console.ReadLine()));
                numberElements--;
            }
            Console.WriteLine(UnfairnessMaxMin(numbers, k));
            
        }

        static int UnfairnessMaxMin(List<int> numbers,int k)
        {
            numbers.Sort();
            var numberArray = numbers.ToArray();
            int min = 100000000; // limit 10^9

            for (int i = 0; i < numberArray.Length - k; i++)
            {
                int temp = numberArray[i + (k - 1)] - numberArray[i];
                if (temp < min)
                    min = temp;
            }

            return min;
        }
    }
}
