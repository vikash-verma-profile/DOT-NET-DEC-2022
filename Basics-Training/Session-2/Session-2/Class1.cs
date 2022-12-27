using System;
using System.Collections.Generic;
using System.Text;

namespace Session_2
{
    class A
    {
       public A(int x)
        {
            Console.WriteLine("Value of x is "+x);
        }
        public void Print()
        {
            Console.WriteLine("Hi I am print from A");
        }
    }
    class B:A
    {
       public B(int x,int y):base(x)
        {
            Console.WriteLine("Value of y is "+y);
            base.Print();
        }
    }
    class C:B
    {
       public C(int x,int y,int z):base(x,y)
        {
            Console.WriteLine("Value of z is " + z);
        }
    }
    class Class1
    {
        public static void Main2()
        {
            C c = new C(1,2,3);
        }
    }
}
