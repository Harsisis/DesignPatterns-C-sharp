using System;
using System.Collections.Generic;

namespace DesignPatterns.entities.Patterns.Flyweight {
    public class Forest {
        public List<Tree> Trees { get; set; }
        public TreeFactory Factory { get; set; }

        public Forest() {
            Factory = new TreeFactory();
            Trees = new List<Tree>();
        }
        public void PlantTree(int x, int y, string name, string color, string texture) {
            TreeType type = Factory.GetTreeType(name, color, texture);
            Trees.Add(new Tree(x, y, type));
        }

        public void Draw() {
            Console.WriteLine("draw Forest");
            Trees.ForEach(t => {
                t.Draw();
            });

        }
    }
}
