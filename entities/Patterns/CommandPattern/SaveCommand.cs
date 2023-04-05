using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.entities.Patterns.CommandPattern {
    public class SaveCommand : ICommand {
        public string Text { get; set; }
        public SaveCommand(string text) { 
            Text = text;
        }
        public void Execute() {
            Console.WriteLine("save command : " + Text);
        }
    }
}
