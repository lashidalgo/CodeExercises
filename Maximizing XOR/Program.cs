using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximizing_XOR
{
    class Program
    {
        //Every time an integer increments, it changes the lowest order bit which eventually carries up into the 
        //higher order bits. So, let's take the endpoints of the range and see how many low order bits we have
        //to get rid of until they are identical; we can do that by dividing each by two and comparing them at each step
        static int maxXor(int l, int r)
        {
            // Find out which bits actually change.
            int i = 1;
            while (l != r)
            {
                l /= 2; 
                r /= 2; 
                i *= 2;
            }
            return i - 1;
        }

        static void Main(String[] args)
        {
            int res;
            int _l;
            _l = Convert.ToInt32(Console.ReadLine());

            int _r;
            _r = Convert.ToInt32(Console.ReadLine());

            res = maxXor(_l, _r);
            Console.WriteLine(res);

        }
    }
}
