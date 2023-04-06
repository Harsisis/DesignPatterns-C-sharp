using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DesignPatterns.entities.Patterns.Interpretor {
    public class Context {
        private static Dictionary<string, List<Row>> Tables = new Dictionary<string, List<Row>>();
        static Context() {
            List<Row> list = new List<Row>();
            list.Add(new Row("Harry", "Cover"));
            list.Add(new Row("Jean", "Bon"));
            list.Add(new Row("Charles", "Leclerc"));
            Tables.Add("personne", list);
            list = new List<Row>();
            list.Add(new Row("T-shirt", "bleu"));
            list.Add(new Row("T-shirt", "blanc"));
            list.Add(new Row("Pull", "noir"));
            list.Add(new Row("Pantalon", "kaki"));
            Tables.Add("vetement", list);
        }

        public string Table { get; set; }
        public string Column { get; set; }
        public Predicate<string> Filter { get; set; }

        public List<string> Search() {
            List<Row> rows = new List<Row>();
            Table.Split(' ').ToList().ForEach(table => {
                if (Tables.ContainsKey(table.ToLower().Trim())) {
                    rows.AddRange(Tables[table]);
                }
            });
            //using filter and select
            Clear();

            return rows.Select(i => i.ToString()).ToList();
        }

        private void Clear() {
            Column = null;
            Table = null;
            Filter = null;
        }
    }
}
