using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleEngineDesignPattern
{
    internal interface IRule
    {
        public bool shouldRun(Recording recording);
        public List<string> runRule(Recording recording);
    }
}
