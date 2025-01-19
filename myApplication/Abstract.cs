using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace myApplication
{
    public abstract class Customer
    {
        //public abstract void print();
        public void print()
        {
            Console.WriteLine( "This line will be executed");
        }
        
    }
    class Professor : Customer
    {
        /*public override void print()
        {
            Console.WriteLine("First Line is excecuted");
        }*/
        public void Main10()
        {
            
        }
    }
}
