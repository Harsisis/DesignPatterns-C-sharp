using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.entities.OrderState {
    public class CommandeLivree : EtatCommande {
        public override void AjouteProduit(Produit produit) {
        }

        public override void Efface() {
        }

        public override EtatCommande EtatSuivant() {
            Console.WriteLine("commande livree");
            return new CommandeLivree();
        }

        public override void RetireProduit(Produit produit) {
        }
    }
}
