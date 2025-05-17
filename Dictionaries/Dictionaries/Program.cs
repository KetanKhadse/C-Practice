using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //unlike list this stores value in the form of key value pair
            //[] will not work here as it will only do search on key in the dictionary in for loop

            Dictionary<int, string> Names = new Dictionary<int, string>
            {
                {1,"Ketan" },
                {2,"Jack" },
                {3,"Batman" },
                {4,"Spiderman" },
                {5,"Superman" }
            };

            foreach (KeyValuePair<int,string> item in Names)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
            Console.WriteLine();
            for (int i = 0; i < Names.Count; i++)
            {
                KeyValuePair<int,string> items = Names.ElementAt(i);
                Console.WriteLine($"{items.Key} - {items.Value}");
            }
            //you can use [] to write a particular element of dictionary using Console.WriteLine();
            //But you should make sure that it exists forst otherwise it will not print the element and throw an exception
            //eg
            //Console.WriteLine(Names[7]); System.Collections.Generic.KeyNotFoundException: 'The given key was not present in the dictionary.'
            //Now to make sure you do not get this error again you can check if the key actualy exist 
            //eg
            Console.WriteLine();
            if (Names.TryGetValue(2,out string names))
            {
                Console.WriteLine(names);

            }
            else
            {
                Console.WriteLine("The key does not exist");
            }
            Console.WriteLine();
            //You can also use removeat just like array to remove certain element form  the dictionary
            //To be on a safer side you can also check if the key exist and then procedd to remove the key
            if (Names.TryGetValue(2,out string name))
            {
                Names.Remove(2);

            }
            else 
            {
                Console.WriteLine("Key Not Found");
            }
            Console.WriteLine();
            foreach (KeyValuePair<int,string> item in Names)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }

        }
    }
}
