using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.entities.Vehicule {
    public class Sujet {
        public List<Observateur> Observateurs { get; set; }

        public void Ajoute(Observateur Observateur) {
            Observateurs.Add(Observateur);
        }
        public void Retire(Observateur Observateur) {
            Observateurs.Remove(Observateur);
        }

        public void Notifie() {
            Observateurs.ForEach(delegate (Observateur obs) {
                obs.actualise();
            });
        }
    }
}
