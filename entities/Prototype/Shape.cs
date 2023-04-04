using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.entities.Prototype {
    public abstract class Shape {
        public int X { get; set; }
        public int Y { get; set; }
        public string Color { get; set; }
        public Shape(Shape source) { 
            X = source.X;
            Y = source.Y;
            Color = source.Color;
        }

        public Shape() { }
        public abstract Shape Clone();

        public abstract void Afficher();
    }
}
