using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utopian_tree
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberTestCases = Convert.ToInt32(Console.ReadLine());
            List<int> heighs = new List<int>();
            var heigh = 1;
            var sprim = true;
            
            //Read test cases number
            while (numberTestCases != 0)
            {
                var numberOfCycles = Convert.ToInt32(Console.ReadLine());
                //Since the tree is planted on spring it start with heigh 1
                heigh = 1;
                
                while (numberOfCycles > 0)
                {
                    if (sprim)
                        heigh = heigh * 2;
                    else
                        heigh = heigh + 1;

                    numberOfCycles--;
                    sprim = !sprim;
                }
                heighs.Add(heigh);
                sprim = true;
                numberTestCases--;
            }

            foreach (int finalHeigh in heighs)
                Console.WriteLine(finalHeigh);

            Console.ReadKey();
        }
    }
}
