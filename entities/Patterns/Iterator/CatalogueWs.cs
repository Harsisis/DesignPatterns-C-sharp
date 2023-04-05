using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.entities.Patterns.Iterator {
    public class CatalogueWs<T, Q> : IteratorWs {
        public IIteratorGlobal<Q> Collection { get; set; }
        public int Position { get; set; } = 0;
        public CatalogueWs(T iterateur) { 
            Collection = (IIteratorGlobal<Q>)iterateur;
        }
        public override object Item() {
            return Collection.GetItems()[Position];
        }

        public override bool MoveNext() {
            if (Position + 1 < Collection.GetItems().Count) {
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
