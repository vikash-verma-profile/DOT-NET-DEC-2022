using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetryPattern
{
    //Delegate signature

    // public delegate int operation(int x,int y);

    delegate void operation();

    internal class Class1
    {
        static int Addition(int a,int b)
        {
            return a + b;
        }
        public static void Main2()
        {
          //  operation obj = new operation(Addition);

            operation obj= delegate
            {
                Console.WriteLine("Anonymous Method");
            };
            obj();
        }
    }
}
