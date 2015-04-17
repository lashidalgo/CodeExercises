using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] toSort = { 6, 2, 3, 1, 5, 4 };
            Console.Write(string.Join(" ", HeapSort(toSort, toSort.Length)));
            Console.ReadKey();
        }

        //O(n log n) http://www.codeproject.com/Articles/79040/Sorting-Algorithms-Codes-in-C-NET
        public static int[] HeapSort(int[] numbers, int arraySize)
        {
            int i;
            int temp;
            for (i = (arraySize / 2) - 1; i >= 0; i--) 
            {
                ShiftDown(numbers, i, arraySize);
            }

            for (i = arraySize - 1; i >= 1; i--)
            {
                temp = numbers[0];
                numbers[0] = numbers[i];
                numbers[i] = temp;
                ShiftDown(numbers, 0, i - 1);
            }
            return numbers;
        }

        public static void ShiftDown(int[] numbers, int root, int bottom)
        {
            int maxChild;
            int temp;
            int done = 0;
            while ((root * 2 <= bottom) && (done == 0))
            {
                if (root * 2 == bottom)
                    maxChild = root * 2;
                else if (numbers[root * 2] > numbers[root * 2 + 1])
                    maxChild = root * 2;
                else
                    maxChild = root * 2 + 1;
                if (numbers[root] < numbers[maxChild])
                {
                    temp = numbers[root];
                    numbers[root] = numbers[maxChild];
                    numbers[maxChild] = temp;
                    root = maxChild;
                }
                else
                    done = 1;
            }
        }
    }
}
