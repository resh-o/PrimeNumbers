using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjCountingPrimes
{
    class Calculations
    {
        public static void SieveOfEratosthenes(int n)
        {
            bool[] prime = new bool[n + 1];
            for (int i = 0; i <= n; i++)
                prime[i] = true;

            for (int p = 2; p * p <= n; p++)
            {
                if (prime[p])
                {
                    for (int i = p * p; i <= n; i += p)
                        prime[i] = false;
                }
            }

            int primeCount = 0;
            for (int i = 2; i <= n; i++)
            {
                if (prime[i])
                    primeCount++;
            }

            Console.WriteLine($"Prime numbers up to {n}");
            for (int i = 2; i <= n; i++)
            {
                if (prime[i])
                    Console.Write(i + " ");
            }

            Console.WriteLine("\n***************************");    
            Console.WriteLine($"Amount of prime numbers: {primeCount}");
            Console.WriteLine("\n***************************");
        }
    }
}
