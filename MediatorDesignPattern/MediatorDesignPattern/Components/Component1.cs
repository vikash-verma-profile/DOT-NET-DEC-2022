using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPattern.Components
{
    internal class Component1:BaseComponent
    {
        //A,B,C,D are dentoting some opetaions
        public void DOA()
        {
            Console.WriteLine("Component 1 does A.");
            this._mediator.Notify(this,"A");
        }
        public void DOB()
        {
            Console.WriteLine("Component 1 does B.");
            this._mediator.Notify(this, "B");
        }
    }
}
