using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.entities.Patterns.Mediator {
    public abstract class Component {

        public IMediator Dialog { get; set; }
        public Component(IMediator dialog) { 
            Dialog = dialog;
        }

        public abstract void Clicked();
        public abstract void KeyPressed();

    }
}
