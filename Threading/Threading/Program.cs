// See https://aka.ms/new-console-template for more information
using System.Data.SqlTypes;
using System.Threading;
using System.Diagnostics;

{
    //Thread o1 = new Thread(RunInfiniteIterations);
    //o1.Start();
    Parallel.For(0, 10000000,x=> RunInfiniteIterations());
   // using ()
}

static void RunInfiniteIterations()
{
    string x = "";

    for (int i = 0; i < 10000000; i++)
    {
        x = x + "s";
    }
}




