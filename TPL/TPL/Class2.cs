//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace TPL
//{
//    using System.Diagnostics;
//{
//    Stopwatch obj = new Stopwatch();
//    Console.WriteLine("Parallel For Loop Execution");
//    obj.Start();
//    List<int> integerList = Enumerable.Range(1, 10).ToList();

//    foreach (int i in integerList)
//    {
//        long total = DoSomeWork();
//    Console.WriteLine("{0} - {1}", i, total);
//    }
//obj.Stop();
//Console.WriteLine("For Loop Execution end");
//Console.WriteLine(obj.ElapsedTicks.ToString());
//obj.Reset();
//obj.Start();
////var options = new ParallelOptions()
////{
////    MaxDegreeOfParallelism= 2
////};
//Parallel.ForEach(integerList, i =>
//{
//    long total = DoSomeWork();
//    Console.WriteLine("{0} - {1}", i, total);
//});
//DateTime EndDataTime = DateTime.Now;
//Console.WriteLine("For Loop Execution end");
//obj.Stop();
//Console.WriteLine(obj.ElapsedTicks.ToString());
  
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
