using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetryPattern
{
    internal class Class2
    {
        public delegate int Calc(int x,int y);
        public static string Add(int a,int b)
        {
           return a + "+" + b+" ="+(a+b);
            
        }
        public static string Multplication(int a, int b)
        {
            return a + "*" + b + " =" + (a * b);
        }
        public static void Main3()
        {
            Calc Cal =Add(1);
            Cal += Multplication(20);
           
            //Cal(1,2);
            //Console.WriteLine("===================");
            //Cal -= Add;
            //Cal(2, 2);

        }
    }
}
