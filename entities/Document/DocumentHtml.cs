using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.entities.Document {
    public class DocumentHtml : IDocument {
        public string Contenu { get; set; }

        public DocumentHtml(string Contenu) { 
            this.Contenu = Contenu;
        }
        public void Dessine() {
            Console.WriteLine("dessine Html");
        }

        public void Imprime() {
            Console.WriteLine("imprime Html");
        }
    }
}
