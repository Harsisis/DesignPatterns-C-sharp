using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.entities.Patterns.ChainOfResponsability.Handler {
    public class AdminHandler : AbstractHandler {
        public override string Handle(string request) {
            Console.WriteLine("Admin handler received request : " + request);
            if (request.Equals("admin")) {
                Console.WriteLine("connect user as admin");
                return "connect user as admin";
            }
            return base.Handle(request);
        }
    }
}
