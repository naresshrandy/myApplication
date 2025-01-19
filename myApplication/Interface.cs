using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myApplication
{
    interface I1
    {
        void InterfaceMethod(); // By Deafult Interafce is Public
    }
    interface I2
    {
        void InterfaceMethod();
    }
    public class Personal : I1,I2
    {
        public void InterfaceMethod() //Deafult Interface
        {
            Console.WriteLine("First Interface will execute");
        }
        void I2.InterfaceMethod()// Explicit Interface
           
        {
            Console.WriteLine("second interface will be executed");        
        }
        public  void Main0()
        {
            
        }
    }
   
        
        
}
