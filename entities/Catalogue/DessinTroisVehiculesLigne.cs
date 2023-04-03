using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.entities.Catalogue {
    public class DessinTroisVehiculesLigne : IDessinCatalogue {
        public void Dessine() {
            Console.WriteLine("trois vehicules par ligne");
        }
    }
}
