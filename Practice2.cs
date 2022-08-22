using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Practice2

    {
        public static void Main()
        {
            int a, b;

            Console.WriteLine("Enter the number a ?");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the number b ?");
            b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine($"{b} is smaller");
            }
            else
            {
                Console.WriteLine($"{a} is smaller");
            }
        }
    }

}

        

