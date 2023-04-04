using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.entities.Patterns.Composite {
    public class SocieteMereComp : SocieteComp {
        public List<SocieteComp> Filiales { get; set; }

        public SocieteMereComp() {
            Filiales = new List<SocieteComp>();
        }

        public override void AjouteFiliale(SocieteComp filiale) {
            Filiales.Add(filiale);
        }

        public override void AjouteVehiule() {
            throw new NotImplementedException();
        }

        public override void CalculEntretien() {
            throw new NotImplementedException();
        }
    }
}
