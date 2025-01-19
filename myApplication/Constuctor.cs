using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myApplication1
{
    internal class Vehicle
    {
        public string model;
        public string color;
        public int year;
        public Vehicle(String modelName, string modelColor, int modelYear ) 
        { 
            model = modelName;
            color = modelColor; 
            year = modelYear;
        }
        public void Main1( String[] args)
        {
            Console.WriteLine($"{model}, {color},{year.ToString()}");

        }
    }
}
