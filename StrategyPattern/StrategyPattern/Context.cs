using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    internal class Context
    {
        private IStrategy strategy;

        public Context()
        {

        }

        public Context(IStrategy _strategy)
        {
            strategy = _strategy;
        }
        public void SetStrategy(IStrategy _strategy)
        {
            strategy = _strategy;
        }
        public void BusinessLogic()
        {
            var result = this.strategy.DoAlogorithm(new List<string> { "a","b","c","d","e"});

            string resultStr = string.Empty;
            foreach (var item in result as List<string>)
            {
                resultStr += item+ ",";
            }
            Console.WriteLine(resultStr);
        }
    }
}
