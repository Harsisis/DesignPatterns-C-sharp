using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.entities.Patterns.Interpretor {
    public class Row {

        public Row(string key, string value) {
            Key = key; Value = value;
        }

        public string Key { get; set; }
        public string Value { get; set; }

        public override string ToString() {
            return Key + " " + Value;
        }
    }
}
