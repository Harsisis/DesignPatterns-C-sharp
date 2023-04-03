using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.entities.OrderState {
    public class CommandeEnCours : EtatCommande {

        public CommandeEnCours() {
            this.Produits = new List<Produit>();
        }
        public override void AjouteProduit(Produit produit) {
            Produits.Add(produit);
        }

        public override void Efface() {
            Produits.Clear();
        }

        public override EtatCommande EtatSuivant() {
            Console.WriteLine("Commande en cours");
            return new CommandeValidee();
        }

        public override void RetireProduit(Produit produit) {
            Produits.Remove(produit);
        }
    }
}
