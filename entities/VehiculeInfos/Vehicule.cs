using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.entities.Vehicule {
    public class Vehicule : Sujet {
        private string Description;
        public void SetDescription(string Description) {
            this.Description = Description;
        }
        public string GetDescription() {
            Notifie();
            return this.Description;
        }
        private float Prix;
        public void SetPrix(float Prix) {
            Notifie();
            this.Prix = Prix;
        }
        public float GetPrix() {
            return Prix;
        }
        public Vehicule(string Description, float Prix) {
            this.Observateurs = new List<IObservateur>();
            this.Description = Description;
            this.Prix = Prix;
        }

        public void setDescription(string Description) {
            this.Description = Description;
            Notifie();
        }

        public string ToString() {
            return Description + "  prix : " + Prix;
        }
    }
}
