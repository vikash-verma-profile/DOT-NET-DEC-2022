// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//for vs pfor

using System.Diagnostics;
{
    Stopwatch obj= new Stopwatch();
    Console.WriteLine("Parallel For Loop Execution");
    obj.Start();
    //for (int i = 0; i < 20; i++)
    //{
    //    long total = DoSomeWork();
    //    Console.WriteLine("{0} - {1}", i, total);
    //}
    Parallel.For(0, 20, i =>
    {
        long total = DoSomeWork();
        Console.WriteLine("{0} - {1}", i, total);
    });
    DateTime EndDataTime=DateTime.Now;
    Console.WriteLine("For Loop Execution end");
    Console.WriteLine(obj.ElapsedTicks.ToString());
    obj.Stop();
}

static long DoSomeWork()
{
    long total = 0;
    for (int i = 0; i < 100000000; i++)
    {
        total +=i;
    }
    return total;
}
