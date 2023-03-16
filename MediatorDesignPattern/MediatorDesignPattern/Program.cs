using MediatorDesignPattern.Components;

namespace MediatorDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Component1 component1= new Component1();
            Component2 component2=new Component2();
            new ConcreteMediator(component1,component2);

            Console.WriteLine("Client triggers opeartion A.");
            component1.DOA();

            Console.WriteLine();


            Console.WriteLine("client triggers opeation D.");
            component2.DOD();
        }
    }
}