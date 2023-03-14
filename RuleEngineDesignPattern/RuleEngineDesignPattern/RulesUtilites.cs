using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleEngineDesignPattern
{
    internal static class RulesUtilites
    {
        public static Boolean isBankOrNull(string str)
        {
            return str == null || str == "";
        }
    }
}
