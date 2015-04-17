using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchSumInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT */
            var sumToSearch = Convert.ToInt32(Console.ReadLine());
            var numberElements = Convert.ToInt32(Console.ReadLine());
            var numbers = new List<int>();
            //Read entry
            while (numberElements != 1)
            {
                numbers.Add(Convert.ToInt32(Console.ReadLine()));
                numberElements--;
            }

            foreach (int firstNuber in numbers)
            {
                foreach (int secondNumber in numbers)
                {
                    if ((firstNuber + secondNumber).Equals(sumToSearch))
                    {
                        Console.WriteLine("1");
                        return;
                    }
                }
            }
            Console.WriteLine("0");
        }
    }
}
