using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.entities.Catalogue {
    public class Catalogue {
        public Catalogue() {

        }

        public List<entities.Vehicule.Vehicule> RetrouveVehicules(float prixMin, float prixMax) {
            List<entities.Vehicule.Vehicule> vehicules = new List<entities.Vehicule.Vehicule>();
            vehicules.Add(new Vehicule.Vehicule("desc", 997f));
            vehicules.Add(new Vehicule.Vehicule("desc", 1000f));
            vehicules.Add(new Vehicule.Vehicule("desc", 1005f));
            vehicules.Add(new Vehicule.Vehicule("desc", 1020f));
            vehicules.Add(new Vehicule.Vehicule("desc", 1003f));
            return vehicules.Where(x => x.GetPrix() >= prixMin && x.GetPrix() <= prixMax).ToList();
        }
    }
}
