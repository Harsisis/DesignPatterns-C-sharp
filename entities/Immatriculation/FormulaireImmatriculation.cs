using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.entities.Immatriculation {
    public abstract class FormulaireImmatriculation {
        public IFormulaireImpl Formulaire { get; set; }
        public string Immatriculation { get; set; }

        protected FormulaireImmatriculation(string immatriculation) {
            Immatriculation = immatriculation;
        }

        public abstract void ControleSaisie();

        public void Affiche() {
            Console.WriteLine("immatriculation");
        }

        public void genereDocument() {
            Console.WriteLine("genere document");
        }

        public void genereSaisie() {
            Console.WriteLine("genere saisie");
        }
    }
}
