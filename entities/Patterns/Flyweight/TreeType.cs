using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.entities.Patterns.Flyweight {
    public class TreeType {
        public string Name { get; set; }
        public string Color { get; set; }
        public string Texture { get; set; }

        public TreeType(string name, string color, string texture) {
            Name = name;
            Color = color;
            Texture = texture;
        }

    }
}
