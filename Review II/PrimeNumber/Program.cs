using System;
using System.Collections;

namespace PrimeNumber
{
    class Program
    {
        static void Main()
        {
            int[] arr = { 23, 3, 4, 6, 44, 8, 7, 6 };

        }
        static public int[] FindPrimeI(int[] arr)
        {
            //create int array Sieve of Eratosthenes
            int limit = int.MaxValue;
            int primeSize = 700000;
            int count = 0;
            

            int[] primes = new int[primeSize];
            int[] numbers = new int[limit];

            //fill the array
            for (int i = 0; i < limit; i++)
            {
                numbers[i] = i + 2;
            }

            //sieve the non-primes
            for (int i = 0; i < limit; i++)
            {
                if (numbers[i] != -1)
                {
                    for (int j = 2 * numbers[i] - 2; j < limit; j += numbers[i])
                    {
                        numbers[j] = -1;
                    }
                }
            }

            //transfer the primes to thier owj array

            int k = 0;
            for (int i = 0; i < limit && k < primeSize; i++)
            {
                if (numbers[i] != -1)
                {
                    primes[k++] = numbers[i];
                }
            }
            for (int i = 2; i < 10000000; i++)
            {
                if (Array.BinarySearch(primes, 1) != -1)
                {
                    count++;
                }
            }
            Console.WriteLine("count = {}", count);
        }
        static public int[] FindPrimeII()
        {
            return new int[10];
        }
        static public int[] FindPrimeIII()
        {
            return new int[10];
        }

    }
}
        
       
            
