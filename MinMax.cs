using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    internal class Minmax
{
    static void Main()
    {
        int[] Arr = { 45, 56, 34, 22, 35, 17, 11 };
        Console.WriteLine("Maximum Element is " + Arr.Max());
        Console.WriteLine("Minimum Element is " + Arr.Min());
        Console.Read();
    }

}
}