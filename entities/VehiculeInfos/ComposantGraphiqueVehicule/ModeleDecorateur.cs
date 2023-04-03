using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.entities.Vehicule.ComposantGraphiqueVehicule {
    public class ModeleDecorateur : Decorateur {
        public string InfosTechnique { get; set; }
        public ModeleDecorateur(string InfosTechnique) {
            this.InfosTechnique = InfosTechnique;
        }
        public void AfficheInfosTechnique() {
            Console.WriteLine(InfosTechnique);
        }
        public override void Affiche() {
            AfficheInfosTechnique();
        }
    }
}
