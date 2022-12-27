// See https://aka.ms/new-console-template for more information
using System.Data.SqlTypes;
using System.Threading;


{
    ////intiallyowned
    //using (var m1=new Mutex(false,"Threading"))
    //{
    //    //check if other external thread is running or not
    //    if (!m1.WaitOne(5000, false)) //checking weather any other instance is there or not
    //    {
    //        Console.WriteLine("already a instance is running");
    //        Console.ReadLine();
    //        return;
    //    }
    //    else
    //    {
    //        Console.WriteLine("I am here");
    //    }
    //    Console.WriteLine("APP is running");
    //    Console.ReadLine();

    //}
    Semaphore s1 = null;
    try
    {
        s1 = Semaphore.OpenExisting("Threading"); //line crash
    }
    catch (Exception ex)
    {
        s1 = new Semaphore(3,3, "Threading");
    }
    s1.WaitOne();
    Console.WriteLine("Thread is acquired");
    Console.ReadLine();
    s1.Release();

}



