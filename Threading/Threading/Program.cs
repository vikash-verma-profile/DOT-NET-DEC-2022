// See https://aka.ms/new-console-template for more information
using System.Threading;

{
    //Console.WriteLine("Hello, World!");
    //Function1();
    //Function2();

    //created 2 threads
    Thread obj1 = new Thread(Function1);
    Thread obj2 = new Thread(Function2);
    obj1.IsBackground = true;
    //invoking these threads
    obj1.Start();
    obj2.Start();
}
static void Function1()
{
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine("Function 1 exectuted " + i.ToString());
        Thread.Sleep(4000);
    }

}

static void Function2()
{
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine("Function 2 exectuted " + i.ToString());
        Thread.Sleep(4000);
    }

}



