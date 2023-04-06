using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace DesignPatterns.entities.Patterns.Interpretor {
    public class Context {
        private static Dictionary<string, List<Row>> Tables = new Dictionary<string, List<Row>>();
        public string Table { get; set; }
        public string Column { get; set; }
        public Predicate<string> Filter { get; set; }

        public List<string> Search() {
            List<Row> rows = new List<Row>();
            if (Tables.ContainsKey(Table.ToLower().Trim())) {
                rows.AddRange(Tables[Table]);
            }

            List<string> stringRows = rows.Select(i => i.ToString()).ToList();
            if (Column.Equals("key")) {
                stringRows = rows.Select(i => i.Key).ToList();
            } else if (Column.Equals("value")) {
                stringRows = rows.Select(i => i.Value).ToList();
            }

            if (Filter != null) {
                stringRows = stringRows.FindAll(Filter);
            }

            Clear();
            return stringRows;
        }

        private void Clear() {
            Column = null;
            Table = null;
            Filter = null;
        }

        static Context() {
            List<Row> list = new List<Row>();
            list.Add(new Row("Harry", "Cover"));
            list.Add(new Row("Jean", "Bon"));
            list.Add(new Row("Emma", "Turquoise"));
            list.Add(new Row("Liam", "Azur"));
            list.Add(new Row("Olivia", "Or"));
            list.Add(new Row("Noah", "Marron roux"));
            list.Add(new Row("Ava", "Rouge cardinal"));
            list.Add(new Row("William", "Bleu paon"));
            list.Add(new Row("Sophia", "Cerise"));
            list.Add(new Row("James", "Brun"));
            list.Add(new Row("Isabella", "Orchidée"));
            list.Add(new Row("Oliver", "Jaune canari"));
            list.Add(new Row("Mia", "Violet foncé"));
            list.Add(new Row("Ethan", "Vert prairie"));
            list.Add(new Row("Amelia", "Fuchsia"));
            list.Add(new Row("Benjamin", "Gris perle"));
            list.Add(new Row("Charlotte", "Rose bonbon"));
            list.Add(new Row("Lucas", "Magenta"));
            list.Add(new Row("Harper", "Bordeaux"));
            list.Add(new Row("Mason", "Vert olive"));
            list.Add(new Row("Evelyn", "Bleu cobalt"));
            list.Add(new Row("Logan", "Orangé"));
            list.Add(new Row("Abigail", "Indigo"));
            list.Add(new Row("Elijah", "Bleu ciel"));
            list.Add(new Row("Emily", "Rouge brique"));
            list.Add(new Row("Alexander", "Beige"));
            list.Add(new Row("Avery", "Gris acier"));
            list.Add(new Row("Daniel", "Marron chocolat"));
            list.Add(new Row("Sofia", "Bleu turquoise"));
            list.Add(new Row("Matthew", "Vert émeraude"));
            list.Add(new Row("Madison", "Lavande"));
            list.Add(new Row("Joseph", "Rose saumon"));
            Tables.Add("personne", list);
            list = new List<Row>();
            list.Add(new Row("T-shirt", "blanc"));
            list.Add(new Row("Pantalon", "bleu marine"));
            list.Add(new Row("Robe", "rouge"));
            list.Add(new Row("Veste", "gris clair"));
            list.Add(new Row("Chaussures", "noir"));
            list.Add(new Row("Chemise", "jaune pâle"));
            list.Add(new Row("Jupe", "vert olive"));
            list.Add(new Row("Pull-over", "bleu ciel"));
            list.Add(new Row("Short", "rose"));
            list.Add(new Row("Manteau", "beige"));
            list.Add(new Row("Chapeau", "rouge foncé"));
            list.Add(new Row("Sac à main", "marron"));
            list.Add(new Row("Sweat à capuche", "gris foncé"));
            list.Add(new Row("Costume", "bleu foncé"));
            list.Add(new Row("Débardeur", "orange"));
            list.Add(new Row("Tennis", "blanc et noir"));
            list.Add(new Row("Pyjama", "violet"));
            list.Add(new Row("Ceinture", "kaki"));
            list.Add(new Row("Maillot de bain", "turquoise"));
            list.Add(new Row("Sandales", "argent"));
            list.Add(new Row("Chemisier", "rouge foncé"));
            list.Add(new Row("Jean", "bleu clair"));
            list.Add(new Row("Veste en cuir", "noir"));
            list.Add(new Row("Jupe crayon", "gris"));
            list.Add(new Row("Chaussures de sport", "blanc et vert"));
            list.Add(new Row("Robe de soirée", "argent"));
            list.Add(new Row("Polo", "bleu marine"));
            list.Add(new Row("Pantalon en lin", "beige clair"));
            list.Add(new Row("Sweat-shirt", "rose pâle"));
            list.Add(new Row("Bottes", "marron foncé"));
            list.Add(new Row("T-shirt à manches longues", "noir"));
            list.Add(new Row("Legging", "violet foncé"));
            list.Add(new Row("Chemise à carreaux", "bleu et rouge"));
            list.Add(new Row("Sacoche", "gris foncé"));
            list.Add(new Row("Pull", "orange brûlé"));
            list.Add(new Row("Short en jean", "bleu foncé"));
            list.Add(new Row("Tennis de running", "noir et blanc"));
            list.Add(new Row("Blouse", "blanc cassé"));
            list.Add(new Row("Combinaison", "vert forêt"));
            list.Add(new Row("Espadrilles", "bleu ciel"));
            list.Add(new Row("T-shirt à col rond", "bleu foncé"));
            list.Add(new Row("T-shirt imprimé", "blanc et rouge"));
            list.Add(new Row("T-shirt oversize", "noir"));
            list.Add(new Row("T-shirt à manches courtes", "jaune"));
            list.Add(new Row("T-shirt en coton biologique", "vert clair"));
            list.Add(new Row("T-shirt à slogan", "rose"));
            list.Add(new Row("T-shirt décontracté", "gris chiné"));
            list.Add(new Row("T-shirt en lin", "bleu ciel"));
            list.Add(new Row("T-shirt à col en V", "noir et blanc"));
            list.Add(new Row("T-shirt à rayures", "rouge et blanc"));
            Tables.Add("vetement", list);
        }
    }
}
