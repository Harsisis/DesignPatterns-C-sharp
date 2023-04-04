using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.entities.Document.Liasse {
    public interface IConstructeurLiasseVehicule {

        public Liasse Liasse { get; set; }
        public abstract void ConstruitBonDeCommande();
        public abstract void ConstruitDemandeImmatriculation();
        public void Resultat() {
            Liasse.Documents.ForEach(doc => {
                doc.Imprime();
            });
        }
    }
}
