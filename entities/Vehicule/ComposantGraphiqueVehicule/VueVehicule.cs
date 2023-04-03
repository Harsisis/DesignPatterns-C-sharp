using DesignPatterns.entities.Vehicule.AnimationVehicule;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.entities.Vehicule.ComposantGraphiqueVehicule {
    public class VueVehicule : IComposantGraphiqueVehicule {

        public IAnimation Animation { get; set; }
        public VueVehicule(IAnimation Animation) {
            this.Animation = Animation;
        }
        public void Affiche() {
            Console.WriteLine("magnifique vue du vehicule");
        }
    }
}
