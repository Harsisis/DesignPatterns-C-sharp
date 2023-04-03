using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.entities.Vehicule.ComposantGraphiqueVehicule {
    internal class MarqueDecorateur : Decorateur {
        public string Logo { get; set; }

        public MarqueDecorateur(string Logo) {
            this.Logo = Logo;
        }
        public void AfficheLogo() {
            Console.WriteLine(Logo);
        }
        public override void Affiche() {
            AfficheLogo();
        }
    }
}
