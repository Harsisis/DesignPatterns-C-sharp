using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DesignPatterns.entities.Patterns.Mediator {
    public interface IMediator {
        void Notify(Component sender, string message);
    }
}
