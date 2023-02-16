namespace WhenKeywordExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            Program p=new Program();
            p.M1();
            Console.WriteLine("=============================");
            p.M2();
        }
        public void M1()
        {
            try
            {
                Console.WriteLine("M1");
                DoSomething();
            }
            catch(Exception ex) { if (print("IF")) Console.WriteLine("I am into if"); }
        }
        public void M2()
        {
            try
            {
                Console.WriteLine("M2");
                DoSomething();
            }
            catch (Exception ex) when (print("WHEN")) { Console.WriteLine("I am into when"); }

        }
        public void DoSomething()
        {
            int a=1,b = 0;
            try
            {
                Console.WriteLine("Hello from DoSomething()");
                int s = a/ b;
            }
            finally { Console.WriteLine("I am in finally"); }
        }
        public bool print(string message)
        {
            Console.WriteLine("Hello "+ message);
            return true;
        }
    }
}