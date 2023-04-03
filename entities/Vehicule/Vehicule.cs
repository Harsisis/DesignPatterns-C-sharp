using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.entities.Vehicule {
    public class Vehicule : Sujet {
        public string Description {
            get => this.Description;
            set {
                this.Description = value;
                Notifie();
            }
        }
        public float Prix {
            get => this.Prix;
            set {
                this.Prix = value;
                Notifie();
            }
        }
        public Vehicule(string Description, float Prix) {
            this.Description = Description;
            this.Prix = Prix;
        }

        public void setDescription(string Description) {
            this.Description = Description;
            Notifie();
        }
    }
}
