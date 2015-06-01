using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Funny_String
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberElements = Convert.ToInt32(Console.ReadLine());
            var results = new List<string>();
            //Read entry
            while (numberElements != 0)
            {
                results.Add(IsFunnyString(Encoding.ASCII.GetBytes(Console.ReadLine().ToCharArray())));
                numberElements--;
            }

            foreach (var result in results)
            {
                Console.WriteLine(result);
            }
            Console.ReadKey();
        }

        static string IsFunnyString(byte[] str)
        {
            var reversed = str.Reverse().ToArray();

            for (int i = str.Length - 1; i > 0; i--)
            {
                if (!Math.Abs(reversed[i - 1] - reversed[i]).Equals(Math.Abs(str[i - 1] - str[i])))
                    return "Not Funny";
            }

            return "Funny";
        }
    }
}
