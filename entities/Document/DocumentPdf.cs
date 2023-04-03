using DesignPatterns.entities.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.entities.Document {
    public class DocumentPdf : IDocument {
        public string Contenu { get; set; }

        public DocumentPdf(string Contenu) {
            this.Contenu = Contenu;
        }

        public void Dessine() {
            Console.WriteLine("dessine PDF  en utilisant la lib");
            ComposantPdf.DessinerPdf(Contenu);
        }

        public void Imprime() {
            Console.WriteLine("imprime PDF en utilisant la lib");
            ComposantPdf.ImprimerPdf(Contenu);
        }
    }
}
