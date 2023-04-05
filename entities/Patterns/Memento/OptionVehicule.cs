using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.entities.Patterns.Memento {
    public class OptionVehicule {
        public string optionName { get; set; }
        public List<OptionVehicule> OptionsIncompatibles { get; set; }
    }
}
