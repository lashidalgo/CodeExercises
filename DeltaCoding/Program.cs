using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeltaCoding
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(r => Convert.ToInt32(r)).ToList();
            var firstNumber = numbers.First();
            bool firstLoop = true;
            string outString = string.Empty;
            
            foreach(int number in numbers){
                if(firstLoop){
                    firstLoop = false;
                    outString = number.ToString();
                }else{
                    if(-127 <= number-firstNumber && number-firstNumber <= 127){
                        outString += " " + (number-firstNumber).ToString();    
                    }else{
                        outString += " -128 " + (number-firstNumber).ToString();   
                    }
                    firstNumber = number;
                }
            }
            Console.WriteLine(outString);
        }
    }
}
