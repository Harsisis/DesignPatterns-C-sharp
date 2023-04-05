using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.entities.Patterns.CommandPattern {
    public class Invoker {
        public ICommand Command { get; set; }

        public void SetCommand(ICommand command) {
            Command = command;
        }
        public void Execute() {
            Console.WriteLine("Invoker: Start COMMAND");
            if (this.Command is ICommand) {
                this.Command.Execute();
            }
        }
    }
}
