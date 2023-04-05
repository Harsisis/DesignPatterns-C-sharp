using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.entities.Patterns.Interpretor {
    public  abstract class Expression {
        public OperateurBinaire OperateurGauche { get; set; }
        public OperateurBinaire OperateurDroite { get; set; }
        public abstract void Evalue(string description);
    }
}
