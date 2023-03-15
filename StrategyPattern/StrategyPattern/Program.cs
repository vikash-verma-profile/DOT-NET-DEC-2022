namespace StrategyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var context = new Context();

            Console.WriteLine("send through BlueDart");
            context.SetStrategy(new StrategyA());
            context.BusinessLogic();

            Console.WriteLine("send through Delivery");
            context.SetStrategy(new StrategyB());
            context.BusinessLogic();

        }
    }

    //BlueDart
    class StrategyA : IStrategy
    {
        public object DoAlogorithm(object data)
        {
            var list = data as List<string>;
            list.Sort();
            Console.WriteLine("=====A=============");
            return list;
        }
    }
    //Delhivery
    class StrategyB : IStrategy
    {
        public object DoAlogorithm(object data)
        {
            var list = data as List<string>;
            list.Sort();
            list.Reverse();
            Console.WriteLine("=====B=============");
            return list;
        }
    }
}