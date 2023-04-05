using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.entities.Patterns.Mediator {
    public class AuthenticationDialog : IMediator {

        public string TitleDialog { get; set; }
        public Button ValidBtn { get; set; }
        public TextField Login { get; set; }
        public TextField Password { get; set; }
        public AuthenticationDialog() {
            ValidBtn = new Button(this);
            Login = new TextField(this);
            Password = new TextField(this);
        }
        public void Notify(Component sender, string message) {
            Console.WriteLine(message);
            if (sender == ValidBtn) {
                Console.WriteLine("notify valid button click");
            }
        }
    }
}
