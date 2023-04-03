using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.entities.OrderState {
    public abstract class EtatCommande {
        public List<Produit> Produits { get; set; }
        public Commande Commande { get; set; }

        public abstract void AjouteProduit(Produit produit);
        public abstract void RetireProduit(Produit produit);
        public abstract void Efface();
        public abstract EtatCommande EtatSuivant();
    }
}
