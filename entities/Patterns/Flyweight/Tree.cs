using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.entities.Patterns.Flyweight {
    public class Tree {
        public int X { get; set; }
        public int Y { get; set; }
        public TreeType Type { get; set; }
        public Tree(int x, int y, TreeType type) { 
            X = x;
            Y = y;
            Type = type;
        }

        public void Draw() {
            Console.WriteLine("draw tree " + Type.Name + " at " + X + ":" + Y);
        }

    }
}
