using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimesTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter a number: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine($"{number} X {i} = {number*i}");

            //}

            for (int i = 1; i <= 15; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0) 
                {
                    Console.WriteLine("Buzz");
                }
                else if(i%3 == 0 && i%5 ==0)
                {
                    Console.WriteLine("Fizz Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }

            }
        }
    }
}
