using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetic_Progression
{
    class Program
    {
        //Find the lost element in the progression
        static void Main(string[] args)
        {
            //int[] progression = {1,3,5,9,11}; ASC
            int[] progression = { 11, 9, 5, 3, 1 }; //DSC
            int amountOfNumbers = 5;
            int diff = (progression.Last() - progression.First()) / amountOfNumbers;

            for (int i = 0; i < progression.Length; i++)
            {
                if (!(progression[i + 1] - progression[i]).Equals(diff))
                {
                    Console.Write(progression[i] + diff);
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
