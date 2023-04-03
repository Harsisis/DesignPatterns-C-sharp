using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace DesignPatterns.entities.Order.OrderType {
    public class CommandeFrance : Commande {
        private static readonly float TVA = 0.196f;
        public CommandeFrance(float montantHt) : base(montantHt) {
        }

        public override void CalculMontantTva() {
            MontantTva = MontantHt * TVA;
        }
    }
}
