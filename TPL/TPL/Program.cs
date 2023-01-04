// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//for vs pfor

using System.Diagnostics;
{
    Stopwatch obj= new Stopwatch();
    Console.WriteLine("Normal Invoking");
    obj.Start();
    Method1();
    Method2();
    Method3();
    obj.Stop();
    Console.WriteLine(obj.ElapsedTicks.ToString());
    Console.WriteLine("Parallel Invoke  ");
    obj.Reset();
    obj.Start();
    Parallel.Invoke(Method1,Method2,Method3);
    obj.Stop();
    Console.WriteLine(obj.ElapsedTicks.ToString());
}

static void Method1()
{
    Thread.Sleep(200);
    Console.WriteLine("Method 1 is called");
}

static void Method2()
{
    Thread.Sleep(200);
    Console.WriteLine("Method 2 is called");
}


static void Method3()
{
    Thread.Sleep(200);
    Console.WriteLine("Method 3 is called");
}

