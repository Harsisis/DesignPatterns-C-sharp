using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.entities.Patterns.Mediator {
    public class Button : Component {
        public Button(IMediator dialog) : base(dialog) {
        }

        public override void Clicked() {
            Dialog.Notify(this, "click btn");
        }

        public override void KeyPressed() {
            Dialog.Notify(this, "keyPressed btn");
        }
    }
}
