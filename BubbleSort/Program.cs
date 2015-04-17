using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] toSort = { 6,2,3,1,5,4 };
            Console.Write(string.Join(" ",BubbleSort(toSort)));
            Console.ReadKey();
        }

        //O(n²) http://en.wikipedia.org/wiki/Bubble_sort
        public static int[] BubbleSort(int[] arrayToSort)
        {
            for (var i = 1; i < arrayToSort.Length; i++)
            {
                for (var j = 0; j < arrayToSort.Length - i; j++)
                {
                    if (arrayToSort[j] > arrayToSort[j+1])
                    {
                        var aux = arrayToSort[j];
                        arrayToSort[j] = arrayToSort[j + 1];
                        arrayToSort[j + 1] = aux;
                    }
                }
            }
            return arrayToSort;
        }
    }
}
