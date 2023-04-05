using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.entities.Patterns.Builder.Pizza {
    internal class LePetitPizzaillolo : IPizzaBuilder {
        
        public Pizza Pizza { get; set; }
        public void NewPizza() {
            Pizza = new Pizza();
        }
        public LePetitPizzaillolo() {
            Pizza = new Pizza();
        }
        public void BuildCheese() {
            Pizza.Ingredients.Add("cheese");
        }

        public void BuildChorizo() {
            Pizza.Ingredients.Add("chorizo");
        }

        public void BuildCreamBase() {
            Pizza.Ingredients.Add("cream base");
        }

        public void BuildHam() {
            Pizza.Ingredients.Add("ham");
        }

        public void BuildMozarella() {
            Pizza.Ingredients.Add("mozarella");
        }

        public void BuildPizzaDough() {
            Pizza.Ingredients.Add("pizza dough");
        }

        public void BuildSpicyOil() {
            Pizza.Ingredients.Add("spicy oil");
        }

        public void BuildTomatoBase() {
            Pizza.Ingredients.Add("tomato sauce");
        }
        public void BuildSalmon() {
            Pizza.Ingredients.Add("salmon");
        }

        public Pizza Cook() {
            return Pizza;
        }

    }
}
