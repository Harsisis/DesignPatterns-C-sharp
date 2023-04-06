using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.entities.Patterns.Interpretor {
    public interface IExpression {
        public List<string> Interpret(Context ctx);
    }
}
