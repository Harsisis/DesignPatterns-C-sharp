using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DesignPatterns.entities.Document {
    public class LiasseVierge {

        private static LiasseVierge instance;
        public static LiasseVierge GetInstance() {
            if(instance == null) {
                instance = new LiasseVierge();
            }
            return instance;
        }
        public List<IDocument> Documents { get; set; }
        private LiasseVierge() { 
            Documents = new List<IDocument>();
        }

        public void AjouteDoc(IDocument document) {
            Console.WriteLine("document ajoute au singleton");
            Documents.Add(document);
        }

        public void RetireDoc(IDocument document) {
            Documents.Remove(document);
        }
    }
}
