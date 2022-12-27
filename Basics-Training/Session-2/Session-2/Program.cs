using System;

namespace Session_2
{
    class baseClass
    {
        public virtual void show()
        {
            Console.WriteLine("Hi I am in show Method in Base");
        }
        public void print()
        {
            Console.WriteLine("Hi I am in Print Method in Base");
        }
    }
    class derivedClass:baseClass
    {
        public override void show()
        {
            Console.WriteLine("Hi I am in show Method in Derived");
        }
        public void print()
        {
            Console.WriteLine("Hi I am in Print Method in Derived");
        }
    }
    class Program
    {
        static void Main1(string[] args)
        {
            baseClass b = new baseClass();
            //b.show();
            //derivedClass d = new derivedClass();
            //d.show();
            b = new derivedClass();
            b.show();
        }
    }
}
