using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.entities.Vehicule.AnimationVehicule {
    public class Film : IAnimation {
        public void Clic() {
            Console.WriteLine("cliquer le film");
        }

        public void Dessine() {
            Console.WriteLine("dessiner le film");
        }
        public void Charge() {
            Console.WriteLine("charger le film");
        }
        public void Joue() {
            Console.WriteLine("Jouer le film");
        }
    }
}
