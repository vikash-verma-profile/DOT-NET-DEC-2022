﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPattern.Components
{
    internal class BaseComponent
    {
        protected IMediator _mediator;
        public BaseComponent(IMediator mediator=null)
        {
            _mediator = mediator;
        }
        public void SetMediator(IMediator mediator)
        {
            this._mediator = mediator;
        }
    }
}
