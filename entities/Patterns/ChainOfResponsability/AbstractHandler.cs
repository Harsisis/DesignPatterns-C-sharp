using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.entities.Patterns.ChainOfResponsability {
    public class AbstractHandler : IHandler {

        public IHandler NextHandler { get; set; }
        public virtual string Handle(string request) {
            if (NextHandler != null) {
                return NextHandler.Handle(request);
            }
            Console.WriteLine("no matching handler, request unhandled");
            return null;
        }

        public IHandler SetNext(IHandler handler) {
            NextHandler = handler;
            return handler;
        }
    }
}
