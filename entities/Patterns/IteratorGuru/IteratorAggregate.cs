using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.entities.Patterns.Iterator {
    public abstract class IteratorAggregate : IEnumerable {
        public abstract IEnumerator GetEnumerator();
    }
}
