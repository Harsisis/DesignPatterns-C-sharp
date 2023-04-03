using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.entities.Vehicule.AnimationVehicule {
    public class AnimationProxy : IAnimation {
        public string Photo { get; set; }
        public Film Film { get; set; }
        public void Clic() {
            if(Film == null) {
                Film = new Film();
                Film.Charge();
            }
            Film.Joue();
        }

        public void Dessine() {
            if(Film != null) {
                Film.Dessine();
            } else {
                DessinePhoto(Photo);
            }
        }

        public void DessinePhoto(string photo) {
            Console.WriteLine("dessine photo : " + photo);
        }
    }
}
