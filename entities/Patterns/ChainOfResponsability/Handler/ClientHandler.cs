using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.entities.Patterns.ChainOfResponsability.Handler {
    public class ClientHandler : AbstractHandler {
        public override string Handle(string request) {
            Console.WriteLine("Client handler received request : " + request);
            if (request.Equals("connect")) {
                Console.WriteLine("connect user");
                return "connect user";
            }
            return base.Handle(request);
        }
    }
}
