using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.entities.Prototype {
    public class Circle : Shape {
        public int Radius { get; set; }
        public Circle(Circle source) : base(source) {
            Radius = source.Radius;
        }
        public Circle() {
        }

        public override Shape Clone() {
            return new Circle(this);
        }

        public override void Afficher() {
            Console.WriteLine("circle : " + X + " "+ Y + " " + Radius + " " + Color);
        }
    }
}
