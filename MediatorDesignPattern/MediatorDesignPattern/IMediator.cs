using MediatorDesignPattern.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPattern
{
    //a method used by components to notify the mediator about various events
    internal interface IMediator
    {
        void Notify(object sender,string ev);
    }
    //implement behaviour

    //Helping up to cordinate in-Between two components
    class ConcreteMediator : IMediator
    {
        private Component1 _component1;
        private Component2 _component2;
        public ConcreteMediator(Component1 component1, Component2 component2)
        {
            _component1 = component1;
            _component1.SetMediator(this);
            _component2 = component2;
            _component2.SetMediator(this);
        }

        public void Notify(object sender, string ev)
        {
            if (ev=="A")
            {
                Console.WriteLine("Mediator reacts on A and trigger the Operation");
                this._component2.DOC();
            }
            if (ev == "D")
            {
                Console.WriteLine("Mediator reacts on D and trigger the Operation");
                this._component1.DOB();
                this._component2.DOC();
            }
        }
    }
}
