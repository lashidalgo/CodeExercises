using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flipping_bits
{
    class Program
    {
        static void Main(string[] args)
        {
            var intList = new List<uint>();
            for (var i = int.Parse(Console.ReadLine()); i > 0; i--)
            {
                intList.Add(~uint.Parse(Console.ReadLine()));
            }
            intList.ForEach(Console.WriteLine);
        }
    }
}
