using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.entities.Document.Liasse {
    public class ConstructeurLiasseVehiculeHtml : IConstructeurLiasseVehicule {
        public Liasse Liasse { get; set; }

        public void ConstruitBonDeCommande() {
            throw new NotImplementedException();
        }

        public void ConstruitDemandeImmatriculation() {
            throw new NotImplementedException();
        }
    }
}
