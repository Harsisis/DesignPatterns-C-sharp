using DesignPatterns.entities.Vehicule.AnimationVehicule;
using DesignPatterns.entities.Vehicule.ComposantGraphiqueVehicule;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.entities.Vehicule {
    public class VueVehicule : IComposantGraphiqueVehicule {
        public Vehicule Vehicule { get; set; }
        public IAnimation Animation { get; set; }
        public VueVehicule(IAnimation Animation) {
            this.Animation = Animation;
        }
        public void Affiche() {
            Console.WriteLine("magnifique vue du vehicule");
        }

        public void Actualise() {
            Redessine();
        }

        public void Redessine() {

        }
    }
}
