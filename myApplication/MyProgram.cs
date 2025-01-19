using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myApplication
{
    internal class Car
    {
        public string color = "red";
    }
    class Program
    {
        public static void Main111(string[] args)
        {
            Car obj = new(); // created 2 objects
            Car obj2 = new();
            Console.WriteLine(obj.color); // prints 2 times
            Console.WriteLine(obj2.color);
        }
    }
    
}
