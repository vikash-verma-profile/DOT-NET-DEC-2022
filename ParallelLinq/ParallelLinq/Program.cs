// See https://aka.ms/new-console-template for more information
using ParallelLinq;
using System.Diagnostics;
using System.Threading.Tasks.Dataflow;
{
    //Console.WriteLine("Hello, World!");
    List<Employee> employees = new List<Employee>() {
        new Employee{ FirstName="Rakesh"},
        new Employee{FirstName="Ramesh"},
        new Employee{FirstName="Jem"},
        new Employee{FirstName="John"},
        new Employee{FirstName="Vikash"}
    };
    Console.WriteLine("Normal Linq");
    Stopwatch obj=new Stopwatch();
    obj.Start();
    var data = from e in employees where e.FirstName.StartsWith("R") select e;
    obj.Stop();
    Console.WriteLine(obj.ElapsedTicks.ToString());
    obj.Reset();
    Console.WriteLine("After using Parallel Linq");
    obj.Start();
    var dataP = from e in employees.AsParallel().WithDegreeOfParallelism(2) where e.FirstName.StartsWith("R") select e;
    obj.Stop();
    Console.WriteLine(obj.ElapsedTicks.ToString());

    foreach (var item in data)
    {
        Console.WriteLine(item.FirstName);
    }
    foreach (var item in dataP)
    {
        Console.WriteLine(item.FirstName);
    }

}

