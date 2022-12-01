using System;

namespace Session1
{
    //class <class-name>
    /*methods
     * data-members/fields
     * constructors
     * destructors
     * enum
     * structures
     * properties
     */

    //keyword <return-type> function name (<arguments>)
    //var ,dynamic

    class Sample
    {
        int a;

        public int Age { get; set; }
        public Sample(int a)
        {
            this.a = a;
        }
        public void show()
        {
            Console.WriteLine(a);
            Console.WriteLine("Hi I am show method");
        }
        ~Sample()
        {
            Console.WriteLine("Printing");
        }
    }
    class Program
    {
      
        static void Main1(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //dynamic i = 1;
            //i = "Vikash";
            //Console.WriteLine(i);

            Sample s = new Sample(4);
            s.show();

            s.Age = 15;
        }
    }
}
