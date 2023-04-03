using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.entities.OrderState {
    public class CommandeValidee : EtatCommande {
        public override void AjouteProduit(Produit produit) {
        }

        public override void Efface() {
        }

        public override EtatCommande EtatSuivant() {
            Console.WriteLine("Commande validee");
            return new CommandeLivree();
        }

        public override void RetireProduit(Produit produit) {
        }
    }
}
