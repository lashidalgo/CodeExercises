using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KindOfTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT */
            var numberTestCases = Convert.ToInt32(Console.ReadLine());
            var triangles = new List<string>();
            //Read entry
            while (numberTestCases != 0)
            {
                triangles.Add(Console.ReadLine());
                numberTestCases--;
            }

            //Write out
            foreach (string triangleText in triangles)
            {
                List<int> triangle = triangleText.Split(' ').Select(r => Convert.ToInt32(r)).ToList();
                triangle = triangle.Distinct().ToList();
                if (triangle.Count.Equals(3))
                {
                    Console.WriteLine("None of these");
                }
                else if (triangle.Count.Equals(2))
                {
                    Console.WriteLine("Isosceles");
                }
                else
                {
                    Console.WriteLine("Equilateral");
                }
            }
        }
    }
}
