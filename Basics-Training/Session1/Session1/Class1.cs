using System;
using System.Collections.Generic;
using System.Text;

namespace Session1
{

    class A
    {
        public A()
        {
            Console.WriteLine("I am A");
        }
        public void show()
        {
            Console.WriteLine("Hi I am show");
        }
    }
    class B :A
    {
        public B()
        {
            Console.WriteLine("I am B");
        }
        public void Print()
        {
            Console.WriteLine("Hi I am Print");
        }
    }

    class Class1
    {
        static void Main2(string[] args)
        {
            B b = new B();
            b.show();
            b.Print();
        }
    }
}
