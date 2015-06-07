using System;
using System.Linq;

namespace Quicksort_1
{
    class Solution
    {
        static string Partition(int[] ar, int left, int right)
        {
            int i = left, j = right;
            int pivot = ar[(left + right) / 2];

            while (i <= j)
            {
                while (ar[i].CompareTo(pivot) < 0)
                    i++;

                while (ar[j].CompareTo(pivot) > 0)
                    j--;

                if (i <= j)
                {
                    // Swap
                    int tmp = ar[i];
                    ar[i] = ar[j];
                    ar[j] = tmp;

                    i++;
                    j--;
                }
            }

            
            // Recursive calls
            if (left < j)
                Partition(ar, left, j);

            if (i < right)
                Partition(ar, i, right);

            return string.Join(" ",ar);
        }

        /* Tail starts here */
        static void Main(String[] args)
        {
            int arSize = Convert.ToInt32(Console.ReadLine());
            int[] elements = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine( Partition(elements, 0, arSize - 1));
            Console.ReadKey();
        }
    }
}
