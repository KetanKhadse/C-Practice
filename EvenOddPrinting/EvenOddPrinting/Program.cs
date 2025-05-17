using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EvenOddPrinting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> even = new List<int>();
            List<int> odd = new List<int>();
            for (int i = 0; i <= 20 ; i++)
            {
                if (i % 2 == 0)
                {
                     even.Add(i);   
                }
                else
                {
                    odd.Add(i);
                }

            }
            Console.WriteLine("The list of even numbers from 0 to 20 is:");
            foreach (var item in even)
            {
                Console.Write($"{item} ");
                
            }
            Console.WriteLine(Environment.NewLine + "The List of odd numbers from 0 to 20 is:");
            foreach(var item in odd)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
