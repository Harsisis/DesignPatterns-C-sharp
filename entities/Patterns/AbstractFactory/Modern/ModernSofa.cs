﻿using DesignPatterns.entities.Patterns.AbstractFactory.Furniture;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.entities.Patterns.AbstractFactory.Modern {
    public class ModernSofa : Sofa {
        public ModernSofa(string color, string name, string description) : base(color, name, description) {
        }

        public override void Show() {
            Console.WriteLine("Modern sofa");
        }
    }
}
