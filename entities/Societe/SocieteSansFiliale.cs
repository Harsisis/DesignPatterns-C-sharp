using DesignPatterns.entities.Visiteur;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.entities.Societe {
    public class SocieteSansFiliale : Societe {
        public SocieteSansFiliale(string nom, string mail, string adresse) : base(nom, mail, adresse) {
        }

        public override void AccepterVisiteur(IVisiteur visiteur) {
            Console.WriteLine("accepter visiteur depuis societe sans filiale");
            visiteur.Visite(this);
        }

        public override void AjouteFiliale(Societe filiale) {
            Console.WriteLine("impossible d'ajouter une filiale");
        }
    }
}
