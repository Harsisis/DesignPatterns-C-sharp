using DesignPatterns.entities.Patterns.AbstractFactory.Furniture;
using System;

namespace DesignPatterns.entities.Patterns.AbstractFactory.Victorian
{
    public class VictorianFactory : IFurnitureFactory
    {
        public Chair CreateChair() {
            return new VictorianChair("", "", "");
        }

        public Sofa CreateSofa() {
            return new VictorianSofa("", "", "");
        }

        public Table CreateTable() {
            return new VictorianTable("", "", "");
        }

        public Wardrobe CreateWardrobe() {
            return new VictorianWardrobe("", "", "");
        }
    }
}
