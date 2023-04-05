using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.entities.Patterns.Iterator {
    public interface IIteratorGlobal<T> {

        public List<T> GetItems();
        public void Add(T item);
    }
}
