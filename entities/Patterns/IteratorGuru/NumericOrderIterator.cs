using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace DesignPatterns.entities.Patterns.Iterator {
    public class NumericOrderIterator : Iterator {

        public NumbersCollection Collection { get; set; }
        public int Position { get; set; } = 0;

        public NumericOrderIterator(NumbersCollection collection) {
            Collection = collection;
        }

        public override object Current() {
            return Collection.GetItems()[Position];
        }

        public override bool MoveNext() {
            if(Position + 1 < Collection.GetItems().Count) {
                Position++;
                return true;
            }
            Console.WriteLine("no next item");
            return false;
        }

        public override void Reset() {
            Position = 0;
        }
    }
}
