using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.entities.Patterns.Iterator {
    public abstract class IteratorWs : IEnumerator {
        object IEnumerator.Current => Item();
        public abstract object Item();
        public abstract bool MoveNext();
        public abstract void Reset();
    }
}
