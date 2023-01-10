using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetryPattern
{
    //Delegate signature

    public delegate int operation(int x,int y);
    internal class Class1
    {
        static int Addition(int a,int b)
        {
            return a + b;
        }
        public static void Main()
        {
            operation obj = new operation(Addition);
            Console.WriteLine(obj(5,10));
        }
    }
}
