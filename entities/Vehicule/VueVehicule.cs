using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.entities.Vehicule {
    public interface VueVehicule {
        public Vehicule Vehicule { get; set; }

        public void Actualise() {
            Redessine();
        }

        public void Redessine() {

        }
    }
}
