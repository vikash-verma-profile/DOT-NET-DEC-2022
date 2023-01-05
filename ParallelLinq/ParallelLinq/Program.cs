// See https://aka.ms/new-console-template for more information
using ParallelLinq;
using System.Diagnostics;
using System.Threading.Tasks.Dataflow;
{
    //List<Employee> employees = new List<Employee>();
    //for (int i = 0; i < 100000; i++)
    //{
    //    var emp = new Employee { FirstName = "Rakesh "+i };
    //    employees.Add(emp);
    //}
    ////Console.WriteLine("Hello, World!");

    //Console.WriteLine("Normal Linq");
    //Stopwatch obj=new Stopwatch();
    //obj.Start();
    //var data = from e in employees where e.FirstName.StartsWith("R") select e;
    //obj.Stop();
    //Console.WriteLine(obj.ElapsedTicks.ToString());
    //obj.Reset();
    //Console.WriteLine("After using Parallel Linq");
    //obj.Start();
    //var dataP = from e in employees.AsParallel().WithExecutionMode(ParallelExecutionMode.ForceParallelism) where e.FirstName.StartsWith("R") select e;
    //obj.Stop();
    //Console.WriteLine(obj.ElapsedTicks.ToString());

    //foreach (var item in data)
    //{
    //    Console.WriteLine(item.FirstName);
    //}
    //foreach (var item in dataP)
    //{
    //    Console.WriteLine(item.FirstName);
    //}

    var numbers = Enumerable.Range(1, 20);
    Stopwatch obj = new Stopwatch();
    obj.Start();
    var evenNumbers = numbers.Where(x=>x%2==0).ToList();
    obj.Stop();
    Console.WriteLine(obj.ElapsedTicks.ToString());
    obj.Reset();
    Console.WriteLine("After using Parallel Linq");
    obj.Start();
    var evenNumbersP = numbers.AsParallel().Where(x => x % 2 == 0).ToList();
    obj.Stop();
    Console.WriteLine(obj.ElapsedTicks.ToString());
    foreach (var item in evenNumbers)
    {
        Console.WriteLine(item);
    }
    Console.WriteLine("===========================================");
    foreach (var item in evenNumbersP)
    {
        Console.WriteLine(item);
    }

    //numbers.asParallel().Sum()
    //numbers.asParallel().Min()
    //numbers.asParallel().Max()
    //numbers.asParallel().Average()
}

