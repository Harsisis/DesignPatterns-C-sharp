using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.entities.Patterns.Iterator {
    public class NumbersCollection : IteratorAggregate {
        public List<int> Collection { get; set; } = new List<int>();

        public List<int> GetItems() { return Collection; }
        public void Add(int item) { 
            Collection.Add(item);
        }

        public override IEnumerator GetEnumerator() {
            return new NumericOrderIterator(this);
        }
    }
}
