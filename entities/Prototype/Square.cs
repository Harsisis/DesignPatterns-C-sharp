using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.entities.Prototype {
    public class Square : Shape {
        public int Side { get; set; }
        public Square(Square source) : base(source) {
            Side = source.Side;
        }

        public override Shape Clone() {
            return new Square(this);
        }

        public override void Afficher() {
            Console.WriteLine("square : " + X + " " + Y + " " + Side + " " + Color);
        }
    }
}
