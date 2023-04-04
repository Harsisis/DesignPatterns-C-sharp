using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.entities.Patterns.Composite {
    public class SocieteSansFilialeComp : SocieteComp {
        public override void AjouteFiliale(SocieteComp filiale) {
            Console.WriteLine("impossible d'ajouter des filiales");
        }

        public override void AjouteVehiule() {
            throw new NotImplementedException();
        }

        public override void CalculEntretien() {
            throw new NotImplementedException();
        }
    }
}
