using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.entities.Immatriculation {
    public class FormAppleImpl : IFormulaireImpl {
        public void DessineTexte() {
            Console.WriteLine("Apple : dessine texte");
        }

        public void gereZoneSaisie() {
            Console.WriteLine("Apple : gere zone saisie");
        }
    }
}
