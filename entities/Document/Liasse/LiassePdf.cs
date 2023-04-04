using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.entities.Document.Liasse {
    public class LiassePdf : Liasse {
        public override void AjoutDocument() {
            Documents.Add(new DocumentPdf(""));
        }

        public override void Imprime() {
            Console.WriteLine("liasse PDF");
            Documents.ForEach(x => x.Dessine());
        }
    }
}
