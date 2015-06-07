using System;

namespace InsertionSortP2
{
    class Solution
    {
        static void InsertionSort(int[] ar)
        {
            int temp, j;
            for (var i = 1; i < ar.Length; i++)
            {
                temp = ar[i];
                j = i - 1;

                while (j >= 0 && ar[j] > temp)
                {
                    ar[j + 1] = ar[j];
                    j--;
                }

                ar[j + 1] = temp;
                Console.WriteLine(String.Join(" ", ar));
            }
        }

        static void Main(String[] args)
        {

            int _ar_size;
            _ar_size = Convert.ToInt32(Console.ReadLine());
            int[] _ar = new int[_ar_size];
            String elements = Console.ReadLine();
            String[] split_elements = elements.Split(' ');
            for (int _ar_i = 0; _ar_i < _ar_size; _ar_i++)
            {
                _ar[_ar_i] = Convert.ToInt32(split_elements[_ar_i]);
            }

            InsertionSort(_ar);
            Console.ReadKey();
        }
    }
}
