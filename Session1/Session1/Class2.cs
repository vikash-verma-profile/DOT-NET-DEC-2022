using System;
using System.Collections.Generic;
using System.Text;

namespace Session1
{

    class SampleClass
    {
        int number1, number2;

        public SampleClass(int _number1,int _number2)
        {
            number1 = _number1;
            number2 = _number2;
        }
        public void Show(int a, int b)
        {

        }
        public void Show(int a, int b, int c)
        {

        }
        public void Show(double a, double b)
        {

        }
        public void Show()
        {
            Console.WriteLine("Number 1="+number1+"Number2="+number2);
        }
        public static SampleClass operator +(SampleClass a, SampleClass b)
        {
            SampleClass c = new SampleClass(0, 0);
            c.number1 = a.number1 + b.number1;
            c.number2 = a.number2 + b.number2;
            return c;
        }
    }
    class Class2
    {


        public static void Main()
        {
            SampleClass a = new SampleClass(1, 2);
            SampleClass b = new SampleClass(1, 2);
            SampleClass c = a + b;
            c.Show();
        }
    }
}
