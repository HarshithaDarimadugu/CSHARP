using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program3
{
    internal class Averagevalue
    {
        public static void Main()
        {
            int[] arr = { 16, 22, 35, 11, 17 };

            int i = 0;
            int sum = 0;
            float average = 0.0F;

            for (i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            average = (float)sum / arr.Length;

            Console.WriteLine("Average of Array elements: " + average);
        }
    }

}

