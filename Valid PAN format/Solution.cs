using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Valid_PAN_format
{
    class Solution
    {
        static void Main(string[] args)
        {          
            int noTestCases = int.Parse(  Console.ReadLine() );
            string[] pans = new string[noTestCases];
            for (int testCase = 0; testCase < noTestCases; testCase++)
            {
                pans[testCase] = Console.ReadLine();
            }
        
            processPANs(pans);
        }

        private static void processPANs(string[] pans)
        {
            foreach (string pan in pans)
            {
                if (isValidPAN(pan))
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
        }

        private static bool isValidPAN(string pan)
        {
            Regex rPan = new Regex(@"^([A-Z]){5}([0-9]){4}([a-zA-Z]){1}?$");

            if (pan.Length != 10)
	        {
                return false;
	        }
           
            return rPan.IsMatch(pan );
        }
    }
}
