using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace DesignPatterns.entities.Patterns.ChainOfResponsability {
    public interface IHandler {
        IHandler SetNext(IHandler handler);

        string Handle(string request);

    }
}
