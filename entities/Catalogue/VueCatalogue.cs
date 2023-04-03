using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.entities.Catalogue {
    public class VueCatalogue {
        public IDessinCatalogue DessinCatalogue { get; set; }
        public VueCatalogue(IDessinCatalogue DessinCatalogue) {
            this.DessinCatalogue = DessinCatalogue;
        }

        public void Dessine() {
            DessinCatalogue.Dessine();
        }
    }
}
