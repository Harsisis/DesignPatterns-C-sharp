﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.entities.Patterns.AbstractFactory.Furniture {
    public abstract class Table {
        public string Color { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Table(string color, string name, string description) {
            Color = color;
            Name = name;
            Description = description;
        }
        public abstract void Show();
    }
}
