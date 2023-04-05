using DesignPatterns.entities.Patterns.AbstractFactory.Furniture;
using System;

namespace DesignPatterns.entities.Patterns.AbstractFactory.Modern {
    public class ModernFactory : IFurnitureFactory
    {
        public Chair CreateChair()
        {
            return new ModernChair("", "", "");
        }

        public Sofa CreateSofa()
        {
            return new ModernSofa("", "", "");
        }

        public Table CreateTable()
        {
            return new ModernTable("", "", "");
        }

        public Wardrobe CreateWardrobe()
        {
            return new ModernWardrobe("", "", "");
        }
    }
}
