//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace TPL
//{
//    {
//    Stopwatch obj = new Stopwatch();
//    Console.WriteLine("Parallel For Loop Execution");
//    obj.Start();
//    //for (int i = 0; i < 20; i++)
//    //{
//    //    long total = DoSomeWork();
//    //    Console.WriteLine("{0} - {1}", i, total);
//    //}
//    var options = new ParallelOptions()
//    {
//        MaxDegreeOfParallelism = 2
//    };
//    Parallel.For(0, 20, options, i =>
//    {
//        long total = DoSomeWork();
//    Console.WriteLine("{0} - {1}", i, total);
//    });
//DateTime EndDataTime = DateTime.Now;
//Console.WriteLine("For Loop Execution end");
//Console.WriteLine(obj.ElapsedTicks.ToString());
//obj.Stop();
//}

//static long DoSomeWork()
//{
//    long total = 0;
//    for (int i = 0; i < 100000000; i++)
//    {
//        total += i;
//    }
//    return total;
//}
//}
