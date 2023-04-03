using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.entities.Vehicule {
    public class Sujet {
        public List<IObservateur> Observateurs { get; set; }

        public void Ajoute(IObservateur Observateur) {
            Observateurs.Add(Observateur);
        }
        public void Retire(IObservateur Observateur) {
            Observateurs.Remove(Observateur);
        }

        public void Notifie() {
            Observateurs.ForEach(delegate (IObservateur obs) {
                obs.Actualise();
            });
        }
    }
}
