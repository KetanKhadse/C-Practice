using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter second number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("To perforn addition use \"+\",To perform subtraction use \"-\",To perform multiplication use \"*\" ,To perform division use \"/\".");
            var Operator = Console.ReadLine();
            Console.WriteLine();
            int result = 0;
            switch (Operator)
            {
                case "+":
                    Add(a, b, out result);
                    Console.WriteLine($"Your answer is {result}");
                    break;
                case "-":
                    Sub(a, b, out result);
                    Console.WriteLine($"Your answer is {result}");
                    break;
                case "*":
                    Mul(a, b, out result);
                    Console.WriteLine($"Your answer is {result}");
                    break;
                case "/":
                    Div(a, b, out result);
                    Console.WriteLine($"Your answer is {result}");
                    break;
                default:
                    Console.WriteLine("Please Restart");
                    break;
            }

        }
     
        static int Add(int a, int b,out int result)
        {
             result =    a + b;
            return result; 
        }
        static int Sub(int a,int b,out int result)
        {

             result= a - b;
            return result;
        }
        static int Mul(int a, int b,out int result)
        {
             result = a * b;
            return result;
        }
        static int Div(int a, int b,out int result)
        { 
            result = a / b;
            return result;
            
        }
        
    }
}
