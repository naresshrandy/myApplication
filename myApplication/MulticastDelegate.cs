using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myApplication
{
    public delegate int SampleDelegate();
     class MulticastDelegate
    {
        public  static void Main16()
        {
            /*SampleDelegate Del = new SampleDelegate(SampleMethodOne);
            Del += SampleMethodTwo;
            Del += SampleMethodThree; //MultiDelegates pointig to functions using +=
            Del();*/

            //SampleDelegate del1, del2, del3, del4;
            //del1 =  new SampleDelegate(SampleMethodOne);
            //del2 = new SampleDelegate(SampleMethodTwo);
            //del3 = new SampleDelegate(SampleMethodThree); //using + opertor to get multiDelegates
            //del4 = del1+ del2 + del3 -del2;
            //del4();

            SampleDelegate d1 =new SampleDelegate(SampleMethodFour);
            d1 += SampleMethodFive;

            int DelegateReturnValue = 0;
            DelegateReturnValue = d1();
            Console.WriteLine("DelegateReturnValue is: {0}", DelegateReturnValue);



            


        }
       /* public static void SampleMethodOne()
        {
            Console.WriteLine("samplemethodone function will executed");
        }
        public static void SampleMethodTwo()
        {
            Console.WriteLine("Samplemethodtwo will be executed");
        }
        public static void SampleMethodThree()
        {
            Console.WriteLine("Samplemethodthree will be executed");
        }*/
        public static int SampleMethodFour()
        {
            return 1;
        }
        public static int SampleMethodFive()
        {
            return 2;
        }
    }

}
