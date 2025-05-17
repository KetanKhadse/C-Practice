using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> Num = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter Number: ");
                int NumItem = Convert.ToInt32(Console.ReadLine());
                Num.Add(NumItem);
                
            }
            for (int i = 0; i < Num.Count; i++)
            {
                Console.Write($"{Num[i]} ");
            }
            Console.WriteLine();
            Num.RemoveAt(1);
            foreach (int i in Num) 
            {
                Console.Write($"{i} ");
            }


        }
    }
}
