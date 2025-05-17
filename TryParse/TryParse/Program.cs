using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter A Number: ");
            string InputNumber =  Console.ReadLine();
            bool success = true;
            while (success) 
            {
                if (int.TryParse(InputNumber, out int num))
                {
                    Console.WriteLine(num);
                    success = false;
                }
                else
                {
                    success = false;
                    Console.WriteLine("Parsing Failed");

                }
            }
        }
    }
}
