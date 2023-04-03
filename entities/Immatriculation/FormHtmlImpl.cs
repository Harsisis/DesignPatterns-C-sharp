using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.entities.Immatriculation {
    public class FormHtmlImpl : IFormulaireImpl {
        public void DessineTexte() {
            Console.WriteLine("Html : dessine texte");
        }

        public void gereZoneSaisie() {
            Console.WriteLine("Html : gere zone saisie");
        }
    }
}

