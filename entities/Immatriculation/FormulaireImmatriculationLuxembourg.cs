using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace DesignPatterns.entities.Immatriculation {
    public class FormulaireImmatriculationLuxembourg : FormulaireImmatriculation {

        private static readonly string REGEX = "/^[A-Z]{2}[0-9]{6}$/";

        public FormulaireImmatriculationLuxembourg(string immatriculation) : base(immatriculation) {
        }
        public override void ControleSaisie() {
            if (Regex.IsMatch(Immatriculation, REGEX)) {
                Console.WriteLine("l'immatriculation : " + Immatriculation + ", est conforme aux plaques luxembourgeoises");
            } else {
                Console.WriteLine("l'immatriculation : " + Immatriculation + ", n'est pas conforme aux plaques luxembourgeoises");
            }
        }
    }
}
