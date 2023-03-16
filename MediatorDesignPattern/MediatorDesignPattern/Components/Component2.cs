using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPattern.Components
{
    internal class Component2:BaseComponent
    {
        public void DOC()
        {
            Console.WriteLine("Component 2 does C.");
            this._mediator.Notify(this, "C");
        }
        public void DOD()
        {
            Console.WriteLine("Component 2 does D.");
            this._mediator.Notify(this, "D");
        }
    }
}
