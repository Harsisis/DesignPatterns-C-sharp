using DesignPatterns.entities;
using DesignPatterns.entities.Catalogue;
using DesignPatterns.entities.Client;
using DesignPatterns.entities.Document;
using DesignPatterns.entities.Immatriculation;
using DesignPatterns.entities.Order;
using DesignPatterns.entities.Order.OrderType;
using DesignPatterns.entities.Patterns.Composite;
using DesignPatterns.entities.Patterns.Prototype;
using DesignPatterns.entities.Societe;
using DesignPatterns.entities.Utils;
using DesignPatterns.entities.Vehicule;
using DesignPatterns.entities.Vehicule.AnimationVehicule;
using DesignPatterns.entities.Vehicule.ComposantGraphiqueVehicule;
using DesignPatterns.entities.Visiteur;
using System;
using System.Collections.Generic;

namespace DesignPatterns
{
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("\n\n########################## pattern STATE ##########################");
            Produit prod1 = new Produit("prod1", "desc1");
            Produit prod2 = new Produit("prod2", "desc2");

            Commande commande1 = new entities.Order.OrderType.CommandeFrance(100f);
            commande1.ajouteProduit(prod1);
            commande1.ajouteProduit(prod2);

            commande1.etatSuivant();// commande en cours
            commande1.etatSuivant();// commande validee
            commande1.etatSuivant();// commande en cours

            Console.WriteLine("\n\n########################## pattern STRATEGY ##########################");
            VueCatalogue vue1 = new VueCatalogue(new DessinUnVehiculeLigne());
            VueCatalogue vue2 = new VueCatalogue(new DessinTroisVehiculesLigne());

            vue1.Dessine();// dessin un vehicule par ligne
            vue2.Dessine();// dessin trois vehicules par ligne

            Console.WriteLine("\n\n########################## pattern ADAPTER ##########################");
            List<IDocument> documents = new List<IDocument>();
            documents.Add(new DocumentHtml("contenu HTML"));
            documents.Add(new DocumentHtml("contenu HTML"));
            documents.Add(new DocumentPdf("contenu PDF"));

            documents.ForEach(delegate (IDocument document) {
                Console.WriteLine(" * new document");
                document.Dessine();
                document.Imprime();
            });

            Console.WriteLine("\n\n########################## pattern SINGLETON ##########################");
            LiasseVierge liasse = LiasseVierge.GetInstance();
            liasse.AjouteDoc(new DocumentHtml("contenu HTML"));
            liasse.AjouteDoc(new DocumentPdf("contenu PDF"));
            liasse.AjouteDoc(new DocumentHtml("contenu HTML"));

            Console.WriteLine("\n\n########################## pattern DECORATOR ##########################");
            VueCatalogue vue3 = new VueCatalogue(new DessinUnVehiculeLigne(), new MarqueDecorateur("Porsche"));
            vue3.ComposantGraphiqueVehicule.Affiche();
            VueCatalogue vue4 = new VueCatalogue(new DessinUnVehiculeLigne(), new VueVehicule(new AnimationProxy(), new Vehicule("desc", 1000f)));
            vue4.ComposantGraphiqueVehicule.Affiche();

            Console.WriteLine("\n\n########################## pattern PROXY ##########################");
            VueVehicule vueVehicule1 = new VueVehicule(new AnimationProxy(), new Vehicule("desc", 1000f));
            vueVehicule1.Animation.Clic();
            Console.WriteLine("");
            vueVehicule1.Animation.Dessine();

            Console.WriteLine("\n\n########################## pattern FACADE ##########################");
            WebServiceAuto serviceAuto = new WebServiceAuto();
            List<entities.Vehicule.Vehicule> vehicules = serviceAuto.ChercherVehicules(1000f, 10f);
            vehicules.ForEach(delegate (Vehicule vehicule) {
                Console.WriteLine(vehicule.ToString());
            });
            Console.WriteLine("number of vehicles found : " + vehicules.Count);// 4

            Console.WriteLine("\n\n########################## pattern OBSERVER ##########################");
            Vehicule vehiculeObs = new Vehicule("description a changer", 1000f);
            VueVehicule vueVehiculeObs = new VueVehicule(new AnimationProxy(), vehiculeObs);
            vehiculeObs.Ajoute(vueVehiculeObs);
            Console.WriteLine("should print new car informations");
            vehiculeObs.SetPrix(2000f);
            vehiculeObs.setDescription("test");

            Console.WriteLine("\n\n########################## pattern TEMPLATE ##########################");
            Commande commandeFr = new CommandeFrance(100f);
            commandeFr.Affiche();
            Commande commandeLu = new CommandeLuxembourg(100f);
            commandeLu.Affiche();

            Console.WriteLine("\n\n########################## pattern BRIDGE ##########################");
            List<FormulaireImmatriculation> forms = new List<FormulaireImmatriculation>();
            forms.Add(new FormulaireImmatriculationFrance("AZE-123-QSD"));// true
            forms.Add(new FormulaireImmatriculationFrance("AZ 1234"));// false
            forms.Add(new FormulaireImmatriculationLuxembourg("AZE-123-QSD"));// true
            forms.Add(new FormulaireImmatriculationLuxembourg("AZ 1234"));// false

            forms.ForEach(delegate (FormulaireImmatriculation formImmat) {
                formImmat.ControleSaisie();
            });

            Console.WriteLine("\n\n########################## pattern VISITOR ##########################");
            Societe soc1 = new SocieteSansFiliale("nom soc1", "mail@soc1.com", "1 adresses societe");
            Societe soc2 = new SocieteSansFiliale("nom soc3", "mail@soc3.com", "3 adresses societe");
            Societe soc3 = new SocieteSansFiliale("nom soc4", "mail@soc4.com", "4 adresses societe");
            Societe soc4 = new SocieteSansFiliale("nom soc5", "mail@soc5.com", "5 adresses societe");
            Societe soc5 = new SocieteSansFiliale("nom soc6", "mail@soc6.com", "6 adresses societe");

            Societe socMere1 = new SocieteMere("nom soc2", "mail@soc2.com", "2 adresses societe");

            socMere1.AjouteFiliale(soc1);
            socMere1.AjouteFiliale(soc2);
            socMere1.AjouteFiliale(soc3);
            socMere1.AjouteFiliale(soc4);
            socMere1.AjouteFiliale(soc5);

            IVisiteur visiteur1 = new VisiteurCalculeCoutEntretien();
            IVisiteur visiteur2 = new VisiteurMailingCommercial();

            Console.WriteLine("\n * visite de societe sans filiale, 2 visitors");
            soc1.AccepterVisiteur(visiteur1);
            soc1.AccepterVisiteur(visiteur2);

            Console.WriteLine("\n * visite de societe avec 5 filiales, 1 visitor");
            socMere1.AccepterVisiteur(visiteur2);

            Console.WriteLine("\n\n########################## pattern FACTORY METHOD ##########################");
            Client client1 = new ClientComptant();
            Client client2 = new ClientCredit();

            client1.NouvelleCommande(100f);
            client1.NouvelleCommande(10f);

            client2.NouvelleCommande(100f);
            client2.NouvelleCommande(10f);// commande invalide

            Console.WriteLine("\nnombre de commandes pour le client 1 : " + client1.Commandes.Count);
            Console.WriteLine("nombre de commandes pour le client 2 : " + client2.Commandes.Count);

            Console.WriteLine("\n\n########################## pattern PROTOTYPE ##########################");
            Circle cir1 = new Circle();
            cir1.X = 5;
            cir1.Y = 5;
            cir1.Radius = 10;
            cir1.Color = "red";

            Circle cir1Copy = (Circle) cir1.Clone();

            cir1.Afficher();
            cir1Copy.Afficher();

            Console.WriteLine("\n\n########################## pattern COMPOSITE ##########################");
            SocieteComp societeMere = new SocieteMereComp();
            societeMere.AjouteFiliale(new SocieteSansFilialeComp());
            societeMere.AjouteFiliale(new SocieteSansFilialeComp());
            SocieteComp societeMereBis = new SocieteMereComp();
            societeMereBis.AjouteFiliale(new SocieteSansFilialeComp());
            societeMereBis.AjouteFiliale(new SocieteSansFilialeComp());
            societeMereBis.AjouteFiliale(new SocieteSansFilialeComp());
            societeMere.AjouteFiliale(societeMereBis);
            Console.WriteLine("check using breakPoint");
        }
    }
}
