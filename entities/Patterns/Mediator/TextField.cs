using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.entities.Patterns.Mediator {
    public class TextField : Component {
        public string Content { get; set; }
        public TextField(IMediator dialog) : base(dialog) {
        }

        public override void Clicked() {
            Dialog.Notify(this, "click textField");
        }

        public override void KeyPressed() {
            Dialog.Notify(this, "keypressed textField");
        }
    }
}
