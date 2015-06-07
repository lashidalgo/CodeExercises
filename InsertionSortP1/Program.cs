using System;

namespace InsertionSortP1
{
    class Solution
    {
        static void InsertionSort(int[] ar)
        {
            var number = ar[ar.Length - 1];

            for (var i = ar.Length - 2; i >= -1; i--)
            {
                if (i < 0)
                {
                    ar[i + 1] = number;
                }
                else if (ar[i] > number)
                {
                    ar[i + 1] = ar[i];
                }
                else
                {
                    ar[ i+1 ] = number;
                    Console.WriteLine(String.Join(" ", ar));
                    break;
                }

                Console.WriteLine(String.Join(" ", ar));
            }
        }
        /* Tail starts here */
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