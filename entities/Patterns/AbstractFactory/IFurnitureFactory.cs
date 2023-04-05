using DesignPatterns.entities.Patterns.AbstractFactory.Furniture;

namespace DesignPatterns.entities.Patterns.AbstractFactory {
    public interface IFurnitureFactory {
        public Chair CreateChair();
        public Table CreateTable();
        public Sofa CreateSofa();
        public Wardrobe CreateWardrobe();

    }
}
