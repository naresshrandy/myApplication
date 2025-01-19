using System;


namespace myApplication
{
    interface I
    {
        void IMethod();
    }
    class A : I
    {
        public void IMethod()
        {
            Console.WriteLine("Naresh");
        }
    }
    interface J
    {
        public void JMethod();
    }
    class B : J
    {
        public void JMethod()
        {
            Console.WriteLine("Ramya");
        }
    }
     public class AB : I, J
    {
        A a=new A();
        B b=new B();
        public void JMethod()
        {
            b.JMethod();
        }
        void I.IMethod()
        {
            ((I)a).IMethod();
        }
    }
    class less
    {
        public void Main12()
        {
            AB ab = new AB();
            ab.JMethod();
            ((I)ab).IMethod();
        }
    }
}
    
