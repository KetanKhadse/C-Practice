using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
             // \t,\n,\",\\,=\   
            string speach = "He Said \"SomeThing\"";
            Console.WriteLine("speach:"+ speach);
            string path = "D:\\Practice Projects\\ECRS-master";
            Console.WriteLine("path:"+path);
            path = @"D:\Practice Projects\ECRS-master";
            Console.WriteLine("path(with @): "+ path);
            string name = @"Hello ""Someone""";
            Console.WriteLine(name);
            name = @"Hello 'Someone'";
            Console.WriteLine(name);
            //task print a string in reverse 
            string word = "Racecar";
         
            for (int i = word.Length - 1; i>=0  ; i--)
            {
                Console.WriteLine(word[i]);
            }

        }
    }
}
