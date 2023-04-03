using DesignPatterns.entities;
using DesignPatterns.entities.Catalogue;
using DesignPatterns.entities.Document;
using DesignPatterns.entities.Vehicule.AnimationVehicule;
using DesignPatterns.entities.Vehicule.ComposantGraphiqueVehicule;
using System;
using System.Collections.Generic;

namespace DesignPatterns {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("\n\npattern STATE ##########################");
            Produit prod1 = new Produit("prod1", "desc1");
            Produit prod2 = new Produit("prod2", "desc2");

            Commande commande1 = new Commande();
            commande1.ajouteProduit(prod1);
            commande1.ajouteProduit(prod2);

            commande1.etatSuivant();// commande en cours
            commande1.etatSuivant();// commande validee
            commande1.etatSuivant();// commande en cours

            Console.WriteLine("\n\npattern STRATEGY ##########################");
            VueCatalogue vue1 = new VueCatalogue(new DessinUnVehiculeLigne());
            VueCatalogue vue2 = new VueCatalogue(new DessinTroisVehiculesLigne());

            vue1.Dessine();// dessin un vehicule par ligne
            vue2.Dessine();// dessin trois vehicules par ligne

            Console.WriteLine("\n\npattern ADAPTER ##########################");
            List<IDocument> documents = new List<IDocument>();
            documents.Add(new DocumentHtml("contenu HTML"));
            documents.Add(new DocumentHtml("contenu HTML"));
            documents.Add(new DocumentPdf("contenu PDF"));

            documents.ForEach(delegate (IDocument document) {
                Console.WriteLine(" * new document");
                document.Dessine();
                document.Imprime();
            });

            Console.WriteLine("\n\npattern SINGLETON ##########################");
            LiasseVierge liasse = LiasseVierge.GetInstance();
            liasse.AjouteDoc(new DocumentHtml("contenu HTML"));
            liasse.AjouteDoc(new DocumentPdf("contenu PDF"));
            liasse.AjouteDoc(new DocumentHtml("contenu HTML"));

            Console.WriteLine("\n\npattern DECORATOR ##########################");
            VueCatalogue vue3 = new VueCatalogue(new DessinUnVehiculeLigne(), new MarqueDecorateur("Porsche"));
            vue3.ComposantGraphiqueVehicule.Affiche();
            VueCatalogue vue4 = new VueCatalogue(new DessinUnVehiculeLigne(), new VueVehicule(new AnimationProxy()));
            vue4.ComposantGraphiqueVehicule.Affiche();

            Console.WriteLine("\n\npattern PROXY ##########################");
            VueVehicule vueVehicule1 = new VueVehicule(new AnimationProxy());
            vueVehicule1.Animation.Clic();
            Console.WriteLine("");
            vueVehicule1.Animation.Dessine();
        }
    }
}
