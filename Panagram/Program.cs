using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panagram
{
    class Program
    {
        static void Main(string[] args)
        {
            //Delete spaces, conver to UpperCase and char array to get the ASCII value
            Console.WriteLine(IsPanagram(Encoding.ASCII.GetBytes(Console.ReadLine().Replace(" ","").ToUpper().ToCharArray()).ToList()));
        }

        //ASCII from [A-Z] ->  [65-90]
        static string IsPanagram(List<byte> readLine)
        {
            readLine = readLine.Distinct().ToList();
            readLine.Sort();

            if (readLine.Count < 26)
            {
                return "not pangram";
            }

            for (int i = 65; i < 90; i++)
            {
                if (!readLine.ElementAt(i - 65).Equals((byte)i))
                {
                    return "not pangram";
                }
            }

            return "pangram";
        }
    }
}
