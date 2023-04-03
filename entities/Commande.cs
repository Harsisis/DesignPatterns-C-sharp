using DesignPatterns.entities.OrderState;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.entities {
    public class Commande {
        public EtatCommande EtatCommande { get; set; }
        public Commande() { 
            EtatCommande = new CommandeEnCours();
        }
        public void ajouteProduit(Produit produit) {
            EtatCommande.AjouteProduit(produit);
        }
        public void retireProduit(Produit produit) {
            EtatCommande.RetireProduit(produit);
        }
        public void efface() {
            EtatCommande.Efface();
        }
        public void etatSuivant() {
            EtatCommande = EtatCommande.EtatSuivant();
        }
    }
}
