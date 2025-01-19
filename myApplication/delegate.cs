using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myApplication
{
    public delegate void HelloFunctionDelegate(string strmessage);
    class Paragim
    {
        public static void Main13()
        {
            HelloFunctionDelegate hello = new HelloFunctionDelegate(Hello);
            hello("This is Randy");
        }
        public static void Hello( string strmessage)
        {
            Console.WriteLine(strmessage);
        }
    }
}
