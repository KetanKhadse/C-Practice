using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Practice1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a = 11;
            //int b = 2;
            //int res = a % b;
            //Console.WriteLine(res);

            double Value = -100D / 30D;
            Console.WriteLine(Value);
            Console.WriteLine(string.Format("{0}",Value));
            Console.WriteLine(string.Format("{0:0.0}",Value));
            Console.WriteLine(string.Format("{0:0.00}",Value));
            //Console.WriteLine(string.Format("${0:0.00}",Value));
            Console.WriteLine(Value.ToString("C"));
            Console.WriteLine(Value.ToString("C0"));
            Console.WriteLine(Value.ToString("C1"));
            Console.WriteLine(Value.ToString("C2"));
            Console.WriteLine(Value.ToString("C3"));
            Console.WriteLine( Value.ToString("c",CultureInfo.CurrentCulture));
            Console.WriteLine( Value.ToString("c",CultureInfo.CreateSpecificCulture("en-GB")));
            Console.WriteLine( Value.ToString("c",CultureInfo.CreateSpecificCulture("IN")));
            

        }

    }
}
