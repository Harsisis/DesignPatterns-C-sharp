using DesignPatterns.entities.OrderState;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.entities.Order
{
    public abstract class Commande
    {
        public EtatCommande EtatCommande { get; set; }
        public float MontantHt { get; set; }
        public float MontantTva { get; set; }
        public float MontantTtc { get; set; }

        public Commande(float montantHt)
        {
            MontantHt = montantHt;
            EtatCommande = new CommandeEnCours();

            CalculMontantTva();
            CalculMontantTtc();
        }
        public void ajouteProduit(Produit produit)
        {
            EtatCommande.AjouteProduit(produit);
        }
        public void retireProduit(Produit produit)
        {
            EtatCommande.RetireProduit(produit);
        }
        public void efface()
        {
            EtatCommande.Efface();
        }
        public void etatSuivant()
        {
            EtatCommande = EtatCommande.EtatSuivant();
        }

        public void CalculMontantTtc() {
            MontantTtc = MontantHt + MontantTva;
        }
        public abstract void CalculMontantTva();

        public abstract void Paye();
        public abstract bool Valid();

        public void Affiche() {
            Console.WriteLine("prix TTC : " + MontantTtc + "e dont " + MontantTva + "e de TVA");
        }

    }
}
