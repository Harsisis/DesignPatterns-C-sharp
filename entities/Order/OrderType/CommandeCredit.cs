using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.entities.Order.OrderType {
    public class CommandeCredit : Commande {
        public CommandeCredit(float montantHt) : base(montantHt) {
        }

        public override void CalculMontantTva() {
            MontantTva = MontantHt * 0.2f;
        }

        public override void Paye() {
            Console.WriteLine("commande credit payee");
        }

        public override bool Valid() {
            if(MontantHt < 100) {
                Console.WriteLine("credit impossible pour les commandes de moins de 100e");
            }
            return MontantHt < 100;
        }
    }
}
