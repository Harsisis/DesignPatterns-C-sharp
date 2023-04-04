using DesignPatterns.entities.Societe;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.entities.Visiteur {
    public class VisiteurMailingCommercial : IVisiteur {
        public void Visite(SocieteSansFiliale societeSansFiliale) {
            Console.WriteLine("visite mailing commercial pour societe sans filiale");
        }

        public void Visite(SocieteMere societeMere) {
            Console.WriteLine("visite mailing commercial pour societe mere");
        }
    }
}
