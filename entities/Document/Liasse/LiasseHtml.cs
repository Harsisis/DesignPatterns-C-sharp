using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.entities.Document.Liasse {
    public class LiasseHtml : Liasse {
        public override void AjoutDocument() {
            Documents.Add(new DocumentHtml(""));
        }

        public override void Imprime() {
            Console.WriteLine("liasse Html");
            Documents.ForEach(x => x.Dessine());
        }
    }
}
