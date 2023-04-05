using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.entities.Patterns.Interpretor {
    public class MotCle : Expression {
        public string keyWord { get; set; }
        public override void Evalue(string description) {
            throw new NotImplementedException();
        }
    }
}
