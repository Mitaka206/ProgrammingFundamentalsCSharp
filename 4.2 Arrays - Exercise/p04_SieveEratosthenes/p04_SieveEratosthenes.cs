using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p04_SieveEratosthenes
{
    class p04_SieveEratosthenes
    {

        public static void Main(string[] args)
        {
            int endNumber = int.Parse(Console.ReadLine());

            
            int count = 0;
            for (int i = 2; i <= endNumber; i++)
            {
                bool isPrime = true;

                for (int j = 2; (j * j) <= i; j++)
                {
                    if ((i % j) == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    count++;
                    //for (int k = 0; k < primes.Length; k++)
                    //{
                    //    primes[k] = i;
                    //}
                    
                   Console.Write (i + " "); 
                } 
            }
            //Console.WriteLine(string.Join(" ", primes));
        }
    }
}

