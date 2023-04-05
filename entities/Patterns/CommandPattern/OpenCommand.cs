using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.entities.Patterns.CommandPattern {
    internal class OpenCommand : ICommand {
        public string Text { get; set; }
        public OpenCommand(string text) {
            Text = text;
        }

        public void Execute() {
            Console.WriteLine("open commande : " + Text);
        }
    }
}
