using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_numbers
{
    class Program
    {
        /*Get number of prime numbers less than a given number
         in 100 out 25
         in 1000000 out 25
        Imp eng http://en.wikipedia.org/wiki/Sieve_of_Eratosthenes*/
        static void Main(string[] args)
        {
            ArrayList primelist = Sieve(100);
            Console.WriteLine(primelist.Count);
            Console.ReadKey();
        }

        static ArrayList Sieve(int maxPrime)
        {
            //Create an array of Bit that will be used as markers, the number to check will be the position in the array
            BitArray positionToCheck = new BitArray(maxPrime, true);
            
            int lastPrime = 1;
            int lastPrimeSquare = 1;

            while (lastPrimeSquare <= maxPrime)
            {
                lastPrime++;

                //If the position was already checked by the last cicle go to the next number
                while (!positionToCheck[lastPrime])
                    lastPrime++;

                lastPrimeSquare = lastPrime * lastPrime;
                //Sieve all elements equal or greater than the square of the las prime, 
                //adding in each loop lastprime + lastprimeSquare
                for (int i = lastPrimeSquare; i < maxPrime; i += lastPrime)
                    if (i > 0)
                        positionToCheck[i] = false;
            }
            
            ArrayList sieve_2_return = new ArrayList();

            for (int i = 2; i < maxPrime; i++)
                if (positionToCheck[i])
                    sieve_2_return.Add(i);

            return sieve_2_return;
        }
    }
}
