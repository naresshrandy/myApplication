using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myApplication
{
    internal class Myclass
    {
        public string color = "red";
        public int maxspeed = 300;
        public void fullThrottle()
        {
            Console.WriteLine("the car is going as fast as it can");
        }
        public static void Main2(string[] args)
        {
            Myclass myclass = new Myclass();
            myclass.fullThrottle();
            //Console.WriteLine();
            Console.WriteLine(myclass.color, myclass.maxspeed.ToString());
        }
    }
}
