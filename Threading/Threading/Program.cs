// See https://aka.ms/new-console-template for more information
using System.Threading;

{
    using (var m1=new Mutex(false,"Threading"))
    {
        if (!m1.WaitOne(5000, false)) //checking weather any other instance is there or not
        {
            Console.WriteLine("already a instance is running");
            Console.ReadLine();
            return;
        }
        Console.WriteLine("APP is running");
        Console.ReadLine();

    }
}



