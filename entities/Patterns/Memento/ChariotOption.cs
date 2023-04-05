using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.entities.Patterns.Memento {
    public class ChariotOption : IMemento {
        public List<OptionVehicule> OptionsVehicules { get; set; }
        public string Etat { get; set; }

        public ChariotOption() { 
            OptionsVehicules = new List<OptionVehicule>();
        }

        public void AjoutOption(OptionVehicule newOption) {
            bool canAddOption = true;
            OptionsVehicules.ForEach(option => {
                canAddOption = option.OptionsIncompatibles.Contains(newOption);
                if (!canAddOption) {
                    Console.WriteLine(newOption.optionName + " incompatible avec l'option " + option.optionName);
                    return;
                }
            });
            if (canAddOption) {
                Console.WriteLine(newOption.optionName + " ajoutee a la liste des options");
                OptionsVehicules.Add(newOption);
            }
        }
    }
}
