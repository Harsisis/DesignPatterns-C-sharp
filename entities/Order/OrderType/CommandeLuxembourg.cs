using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.entities.Order.OrderType {
    internal class CommandeLuxembourg : Commande {
        private static readonly float TVA = 0.15f;
        public CommandeLuxembourg(float montantHt) : base(montantHt) {
        }

        public override void CalculMontantTva() {
            MontantTva = MontantHt * TVA;
        }
    }
}
