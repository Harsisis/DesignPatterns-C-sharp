using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.entities.Patterns.Interpretor {
    public class Select : IExpression {
        public string Column { get; set; }
        public From From { get; set; }

        public Select(string column, From from) {
            Column = column;
            From = from;
        }
        public List<string> Interpret(Context ctx) {
            ctx.Column = Column;
            return From.Interpret(ctx);
        }
    }
}
