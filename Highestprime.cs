using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program6
{
    internal class Highestprime
    {
        static long MaxPrime(long num)
        {
            long CurrMaxPrime = -1;

            //If num is divisible by 2, store CurrMaxPrime
            //as 2. keep on dividing num until it is not 
            //divisible by 2. After each division, update 
            //num as num/2.
            if (num % 2 == 0)
            {
                CurrMaxPrime = 2;
                while (num % 2 == 0)
                {
                    num = num / 2;
                }
            }

            //At this point, num must be odd. Starting with 
            //3 to square root of num , if divisible, divide 
            //and update num, and update CurrMaxPrime
            for (long i = 3; i <= Math.Sqrt(num); i += 2)
            {
                while (num % i == 0)
                {
                    CurrMaxPrime = i;
                    num = num / i;
                }
            }

            //if the modified num is greater than 2, 
            //update the CurrMaxPrime with num 
            if (num > 2)
                CurrMaxPrime = num;

            return CurrMaxPrime;
        }

        static void Main(string[] args)
        {
            long x, y, z;
            x = 42;
            y = 1092;
            z = 695467363456;

            Console.WriteLine($"Largest prime factor of " + x is "Highestprime.MaxPrime(long x)");
            Console.WriteLine($"Largest prime factor of " + y is "Highestprime.MaxPrime(long y)");
            Console.WriteLine($"Largest prime factor of " + z is "Highestprime.MaxPrime(long z)");
        }
    }

}

