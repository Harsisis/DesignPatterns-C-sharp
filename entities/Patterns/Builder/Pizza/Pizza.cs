using System;
using System.Collections.Generic;

namespace DesignPatterns.entities.Patterns.Builder.Pizza {
    public class Pizza {
        public List<string> Ingredients { get; set; }

        public Pizza() {
            Ingredients = new List<string>();
        }

        public void Show() {
            Console.WriteLine("\nLa pizza :");
            Ingredients.ForEach(ingredient => {
                Console.WriteLine(ingredient);
            });
        }
    }
}
