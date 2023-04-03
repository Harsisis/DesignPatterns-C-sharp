using DesignPatterns.entities.Vehicule.ComposantGraphiqueVehicule;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.entities.Catalogue
{
    public class VueCatalogue {
        public IDessinCatalogue DessinCatalogue { get; set; }
        public IComposantGraphiqueVehicule ComposantGraphiqueVehicule { get; set; }
        public VueCatalogue(IDessinCatalogue DessinCatalogue) {
            this.DessinCatalogue = DessinCatalogue;
        }

        public VueCatalogue(IDessinCatalogue DessinCatalogue, IComposantGraphiqueVehicule ComposantGraphiqueVehicule) {
            this.DessinCatalogue = DessinCatalogue;
            this.ComposantGraphiqueVehicule = ComposantGraphiqueVehicule;
        }

        public void Dessine() {
            DessinCatalogue.Dessine();
        }
    }
}
