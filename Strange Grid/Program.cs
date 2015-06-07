using System;
using System.Linq;

namespace Strange_Grid
{
    class Program
    {
        static void Main(string[] args)
        {
            var xy = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Int64 sum = 0;
            var diff = (xy[0] - 1)%2;

            for (var i = 1; i < xy[0] - 1; i+=2)
                    sum += 10;

            if (diff != 0)
                sum += 1;

            sum += (xy[1] - 1) * 2;
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
