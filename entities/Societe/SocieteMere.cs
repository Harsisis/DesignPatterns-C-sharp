using DesignPatterns.entities.Visiteur;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.entities.Societe {
    public class SocieteMere : Societe {
        public SocieteMere(string nom, string mail, string adresse) : base(nom, mail, adresse) {
        }

        public override void AccepterVisiteur(IVisiteur visiteur) {
            Console.WriteLine("accepter visiteur depuis societe mere");
            visiteur.Visite(this);
            Filiales.ForEach(delegate (Societe filiale) {
                filiale.AccepterVisiteur(visiteur);
            });
        }

        public override void AjouteFiliale(Societe filiale) {
            Console.WriteLine("ajout filiale " + filiale.Nom + " a la societe mere " + Nom);
            Filiales.Add(filiale);
        }
    }
}
