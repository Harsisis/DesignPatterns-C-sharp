using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace DesignPatterns.entities.Patterns.Builder {
    public interface IPizzaBuilder {
        void NewPizza();
        void BuildPizzaDough();
        void BuildTomatoBase();
        void BuildCreamBase();
        void BuildChorizo();
        void BuildHam();
        void BuildCheese();
        void BuildMozarella();
        void BuildSpicyOil();
        void BuildSalmon();
        Pizza.Pizza Cook();
    }
}
