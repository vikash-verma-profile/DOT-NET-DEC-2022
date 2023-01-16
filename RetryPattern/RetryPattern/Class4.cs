using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetryPattern
{
    internal class Class4
    {
        public static void Print(int x)
        {
            Console.WriteLine("I am called from Action Delegate "+x);
        }
        public static string Display(int y)
        {
            return "The value of y is "+ y;
        }
        public static void Main5()
        {
            //Action<int> action = Print;
            //action(20);
            Func<int, string> func = Display;
            Console.WriteLine(func(100));
        }
    }
}
