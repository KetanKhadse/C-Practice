using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] Arr = new int[5];
            //for (int i = 0; i < Arr.Length; i++)
            //{
            //    Console.Write($"Enter the number {i+1}:");
            //    int Arrnum = Convert.ToInt32(Console.ReadLine());
            //    Arr[i] = Arrnum;
            //}

            //foreach (int i in Arr) 
            //{
            //    Console.Write($"{i}");
            //}

           int[] newArr = new int[] 
           {
               1,6,4,5,3,7,2,10,32,45,54,65,34,23,65
           };

            /*
             * Array methods return void so there is no need to assign them to a variable unlike string methods 
             * which return a new string as strings are immutable
             */
            Console.Write("Enter your number: ");
            int search = Convert.ToInt32(Console.ReadLine());
            //int position = Array.IndexOf(newArr,search,0,8);
            int position = -1;
            for (int i = 0; i < 10; i++)
            {
                if (newArr[i] == search)
                {
                    position = i;
                }
            }
            if (position >-1) {
                Console.WriteLine($"Your input number  {search} is on index {position} ");
            }
            else
            {
                Console.WriteLine($"Number {search} does not exist.");
            }
            

            //Array.Sort(newArr);
            //foreach (var item in newArr)
            //{
            //    Console.Write(item);
            //}

            //Array.Reverse(newArr);
            //foreach (var item in newArr)
            //{
            //    Console.Write($"{item} ");
            //}

            //Array.Clear(newArr,5,4);
            //for (int i = 7; i < 12; i++)
            //{
            //    newArr[i] = default;
            //}
            //foreach (int i in newArr)
            //{
            //    Console.Write($"{i} ");
            //}

         
            
        }
    }
}
