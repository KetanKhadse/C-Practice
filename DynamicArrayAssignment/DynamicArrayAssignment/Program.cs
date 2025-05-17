using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArrayAssignment
{
    internal class Program
    {
        /*
             * Define and initialize two intigers (num,length)
             * (7,5) -> [7,14,21,28,35]
             * create int array with size length
             * loop through and insert the (loop counter * num) into array
             * print the final array
             */

        static void Main(string[] args)
        {
            int num = 7;
            int length = 5;
            int[] Arr = new int[length];
            int count = 0;
            for (int i = 1; i <= Arr.Length; i++,count++)
            {
                Arr[i-1] = num * i;
            }

            foreach (var item in Arr)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
