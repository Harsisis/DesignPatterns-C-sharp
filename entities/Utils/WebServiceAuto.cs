using DesignPatterns.entities.Document;
using DesignPatterns.entities.Vehicule;
using DesignPatterns.entities.VehiculeInfos;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.entities.Utils {
    public class WebServiceAuto {

        protected RepriseVehicule _repriseVehicule;
        protected GestionDocument _gestionDocument;
        protected entities.Catalogue.Catalogue _catalogue;
        public WebServiceAuto() {
            this._repriseVehicule = new RepriseVehicule();
            this._gestionDocument = new GestionDocument();
            this._catalogue = new Catalogue.Catalogue();
        }

        public List<entities.Vehicule.Vehicule> ChercherVehicules(float PrixMoyen, float EcartMax) {
            _repriseVehicule.RepriseVehiculePrint();
            _gestionDocument.GestionDocumentPrint();
            return _catalogue.RetrouveVehicules(PrixMoyen-EcartMax, PrixMoyen+EcartMax);
        }
    }
}
