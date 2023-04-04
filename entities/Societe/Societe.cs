using DesignPatterns.entities.Visiteur;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace DesignPatterns.entities.Societe {
    public abstract class Societe {
        public string Nom { get; set; }
        public string Mail { get; set; }
        public string Adresse { get; set; }
        public List<Societe> Filiales { get; set; }
        public List<IVisiteur> Visiteurs { get; set; }

        protected Societe(string nom, string mail, string adresse) { 
            Nom = nom;
            Mail = mail;
            Adresse = adresse;
            Filiales = new List<Societe>();
        }

        public abstract void AjouteFiliale(Societe filiale);

        public abstract void AccepterVisiteur(IVisiteur visiteur);


    }
}
