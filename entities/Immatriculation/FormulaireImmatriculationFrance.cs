using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace DesignPatterns.entities.Immatriculation {
    public class FormulaireImmatriculationFrance : FormulaireImmatriculation {

        private static readonly string REGEX = "/[A-HJ-NP-TV-Z]{2}[\\s-]{0,1}[0-9]{3}[\\s-]{0,1}[A-HJ-NP-TV-Z]{2}|[0-9]{2,4}[\\s-]{0,1}[A-Z]{1,3}[\\s-]{0,1}[0-9]{2}/gm";
    public FormulaireImmatriculationFrance(string immatriculation) : base(immatriculation) {
        }

        public override void ControleSaisie() {
            if (Regex.IsMatch(Immatriculation, REGEX)) {
                Console.WriteLine("l'immatriculation : " + Immatriculation + ", est conforme aux plaques francaises");
            } else {
                Console.WriteLine("l'immatriculation : " + Immatriculation + ", n'est pas conforme aux plaques francaises");
            }
        }
    }
}
