using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.entities.Utils {
    public static class ComposantPdf {
        public static void ImprimerPdf(string contenu) {
            Console.WriteLine("impression PDF : " + contenu);
        }
        public static void DessinerPdf(string contenu) {
            Console.WriteLine("dessin PDF : " + contenu);
        }
    }
}
