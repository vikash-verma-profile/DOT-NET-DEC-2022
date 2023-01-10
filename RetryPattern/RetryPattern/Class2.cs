using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetryPattern
{
    internal class Class2
    {
        public delegate void Calc(int x,int y);
        public static void Add(int a,int b)
        {
            Console.WriteLine(a + "+" + b+" ="+(a+b));
        }
        public static void Multplication(int a, int b)
        {
            Console.WriteLine(a + "*" + b + " =" + (a * b));
        }
        public static void Main3()
        {
            Calc Cal =new Calc(Add);
            Cal += Multplication;
           
            Cal(1,2);
            Console.WriteLine("===================");
            Cal -= Add;
            Cal(2, 2);

        }
    }
}
