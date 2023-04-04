using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.entities.Patterns.Composite {
    public abstract class SocieteComp {
        public abstract void AjouteVehiule();
        public abstract void CalculEntretien();
        public abstract void AjouteFiliale(SocieteComp filiale);
    }
}
