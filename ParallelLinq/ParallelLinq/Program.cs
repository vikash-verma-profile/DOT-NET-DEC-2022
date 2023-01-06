// See https://aka.ms/new-console-template for more information
using ParallelLinq;
using System.Diagnostics;
using System.Threading.Tasks.Dataflow;
{
    Console.WriteLine("Main Method");
    //SomeMethod();
    Sample();
    Console.WriteLine("Main Method End");
}
static void Sample()
{
    Task.Delay(TimeSpan.FromSeconds(100000));
    Console.WriteLine("End after task");
}
static async void SomeMethod()
{

    Console.WriteLine("Some method started");
    //  await Task.Delay(TimeSpan.FromSeconds(10));
    await Wait();
    //Console.WriteLine("\n");
    Console.WriteLine("Some method ENd");
}
static async Task Wait()
{
    await Task.Delay(TimeSpan.FromSeconds(10));
    Console.WriteLine("Seconds wait completed");
}

//static async Task Dummy()
//{
//    await WaitCallback();
//}
//static async Task<int> Dummy()
//{
//    await WaitCallback();
//}
//static async void Dummy()
//{
//    await WaitCallback();
//}


