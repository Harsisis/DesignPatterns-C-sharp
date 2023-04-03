using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.entities.Document {
    public interface IDocument {
        public string Contenu { get; set; }
        public void Imprime();
        public void Dessine();
    }
}
