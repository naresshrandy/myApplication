using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myApplication
{
    internal class Person
    {
        private string name; //field
        //public string Name //property
        //{
            //get { return Name; }
            //set { Name = value; }
        //}

        public string NameProperty { get { return name; } set { name = value; } }

        public static void Main3(string[] args)
        {
            Person p = new Person();
          
        }
    }
}
