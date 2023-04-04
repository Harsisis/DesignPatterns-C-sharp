using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.entities.Patterns.Flyweight {
    public class TreeFactory {
        public List<TreeType> TreeTypes { get; set; }

        public TreeFactory() {
            TreeTypes = new List<TreeType>();
            TreeTypes.Add(new TreeType("Hetre", "Claire", "Lisse"));
            TreeTypes.Add(new TreeType("Bouleau", "Blanc", "Lisse"));
            TreeTypes.Add(new TreeType("Chene", "Claire", "Lisse"));
            TreeTypes.Add(new TreeType("Sapin", "Sombre", "Resineux"));
        }

        public TreeType GetTreeType(string name, string color, string texture) {
            return TreeTypes.Where(type => type.Name == name && type.Color == color && type.Texture == texture).SingleOrDefault();
        }
    }
}
