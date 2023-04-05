using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.entities.Patterns.Builder {
    public class PizzaDirector {
        public IPizzaBuilder PizzaBuilder { get; set; }

        public PizzaDirector(IPizzaBuilder pizzaBuilder) {
            PizzaBuilder = pizzaBuilder;
        }
        public void ChorizoMozza() {
            PizzaBuilder.NewPizza();
            PizzaBuilder.BuildPizzaDough();
            PizzaBuilder.BuildTomatoBase();
            PizzaBuilder.BuildChorizo();
            PizzaBuilder.BuildMozarella();
            PizzaBuilder.BuildSpicyOil();

            Pizza.Pizza pizza = PizzaBuilder.Cook();
            pizza.Show();
        }

        public void CreamSalmon() {
            PizzaBuilder.NewPizza();
            PizzaBuilder.BuildPizzaDough();
            PizzaBuilder.BuildCreamBase();
            PizzaBuilder.BuildSalmon();

            Pizza.Pizza pizza = PizzaBuilder.Cook();
            pizza.Show();
        }
    }
}
