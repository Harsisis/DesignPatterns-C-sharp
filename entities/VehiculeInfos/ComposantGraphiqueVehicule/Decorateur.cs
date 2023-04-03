using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.entities.Vehicule.ComposantGraphiqueVehicule {
    public abstract class Decorateur : IComposantGraphiqueVehicule {
        public abstract void Affiche();
    }
}
