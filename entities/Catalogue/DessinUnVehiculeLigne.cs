using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.entities.Catalogue {
    public class DessinUnVehiculeLigne : IDessinCatalogue {
        public void Dessine() {
            Console.WriteLine("un vehicule par ligne");
        }
    }
}
