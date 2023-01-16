using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetryPattern
{
    internal class Class2
    {
        public delegate string Calc(int x,int y);
        public static string Add(int a,int b)
        {
           return a + "+" + b+" ="+(a+b);
            
        }
        public static string Multplication(int a, int b)
        {
            return a + "*" + b + " =" + (a * b);
        }
        public static void Main()
        {
            Calc Cal = Add;
            Cal += Multplication;
            //string result;
             //result = result+Cal(1, 2);
            //Console.WriteLine("===================");
            //Cal -= Add;
            //Cal(2, 2);

        }
    }
}
