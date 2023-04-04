using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.entities.Document.Liasse {
    public abstract class Liasse {

        public List<IDocument> Documents { get; set; }
        public abstract void AjoutDocument();
        public abstract void Imprime(); 
    }
}
