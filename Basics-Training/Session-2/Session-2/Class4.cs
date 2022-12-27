using System;
using System.Collections.Generic;
using System.Text;

namespace Session_2
{
    public class BaseClass
    {
        public virtual string GetMethodOwner()
        {
            return "Base Class";
        }
    }
    public class ChildClass:BaseClass
    {
        public new virtual  string GetMethodOwner()
        {
            return "ChildClass";
        }
    }
    public class SecondClass : ChildClass
    {
        public override  string GetMethodOwner()
        {
            return "Second Level CHild";
        }
    }
    class Class4
    {
        public static void Main5()
        {
            BaseClass  c = new ChildClass();
            Console.WriteLine(c.GetMethodOwner());
        }

    }
}

//Don't 
//new and override
//virtual and override
