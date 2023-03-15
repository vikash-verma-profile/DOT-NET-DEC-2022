using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    internal interface IStrategy
    {
        object DoAlogorithm(object data);
    }
}
