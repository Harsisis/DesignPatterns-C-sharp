using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.entities {
    public class Produit {
        public String Name { get; set; }
        public String Description { get; set; }
        public Produit(string name, string description) { 
            Name = name;
            Description = description;
        }
    }
}
