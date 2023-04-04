using DesignPatterns.entities.Order;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.entities.Client {
    public abstract class Client {
        public List<Commande> Commandes { get; set; }

        protected Client() { 
            Commandes = new List<Commande>();
        }
        public void NouvelleCommande(float prix) {
            Commande commande = CreeCommande(prix);
            if (commande.Valid()) {
                commande.Paye();
                Commandes.Add(commande);
                Console.WriteLine("commande payee est ajoutee a la liste des commandes");
            } else {
                Console.WriteLine("commande invalide");
            }
            
        }
        protected abstract Commande CreeCommande(float prix);

    }
}
