using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.entities.Patterns.ChainOfResponsability.Handler {
    public class VisitorHandler : AbstractHandler {
        public override string Handle(string request) {
            Console.WriteLine("Visitor handler received request : " + request);
            if (request.Equals("visit")) {
                Console.WriteLine("visitor no need to connect");
                return "visitor no need to connect";
            }
            return base.Handle(request);
        }
    }
}
