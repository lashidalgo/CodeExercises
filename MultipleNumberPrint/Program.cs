using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleNumberPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a program that prints the numbers from 1 to 100. But for multiples of three print "Fizz" 
            instead of the number and for the multiples of five print "Buzz". For numbers which are multiples 
            of both three and five print "FizzBuzz"*/

            int i;

            for (i = 1; i <= 100; i++)
            {
                if (i % (3 * 5) == 0) Console.WriteLine("FizzBuzz");
                else if (i % 5 == 0) Console.WriteLine("Buzz");
                else if (i % 3 == 0) Console.WriteLine("Fizz");

                /* default */
                else Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
