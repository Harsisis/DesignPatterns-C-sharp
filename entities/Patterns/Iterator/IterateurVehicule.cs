using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace DesignPatterns.entities.Patterns.Iterator {
    public class IterateurVehicule : IEnumerable, IIteratorGlobal<string> {

        public List<string> Collection { get; set; } = new List<string>();
        public List<string> GetItems() { return Collection; }
        public void Add(string item) {
            Collection.Add(item);
        }
        public IEnumerator GetEnumerator() {
            return new CatalogueWs<IterateurVehicule, string>(this);
        }
    }
}
