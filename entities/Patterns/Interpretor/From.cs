using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace DesignPatterns.entities.Patterns.Interpretor {
    public class From : IExpression {
        public string Table { get; set; }
        public Where Where { get; set; }

        public From(string table) { 
            Table = table;
        }
        public From(string table, Where where) { 
            Table = table;
            Where = where;
        }
        public List<string> Interpret(Context ctx) {
            ctx.Table = Table;
            if(Where == null) {
                return ctx.Search();
            }
            return Where.Interpret(ctx);
        }
    }
}
