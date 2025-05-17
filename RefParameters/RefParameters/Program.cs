using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            Console.WriteLine($"Initial Value: {a}");
            incriment(ref a);
            Console.WriteLine($"New Value: {a}");
            /*
             * The Behaviour of ref is different from the behaviour of regular function because insted of
             * calling the variable by value it is calling the variable by referance
             * meaning insted of making a copy of the variable and using that capy to perform those action it is directly performing that action 
             * on the variable stored in the memory
             */
        }

        static int incriment(ref int a) 
        {
            return a+=a;
        }
    }
}
