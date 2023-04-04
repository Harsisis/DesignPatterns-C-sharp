using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.entities.Order.OrderType
{
    public class CommandeComptant : Commande
    {
        public CommandeComptant(float montantHt) : base(montantHt)
        {
        }
        public override void CalculMontantTva() {
            MontantTva = MontantHt * 0.2f;
        }

        public override void Paye() {
            Console.WriteLine("commande comptant payee");
        }

        public override bool Valid() {
            return true;
        }
    }
}
