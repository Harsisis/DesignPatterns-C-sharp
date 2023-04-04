using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.entities.Societe;

namespace DesignPatterns.entities.Visiteur {
    public interface IVisiteur {
        public void Visite(SocieteSansFiliale societeSansFiliale);

        public void Visite(SocieteMere societeMere);
    }
}
