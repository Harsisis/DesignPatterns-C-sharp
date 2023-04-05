using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.entities.Patterns.MementoGuru {
    public class Caretaker { 
        public List<Memento> BackupList { get; set; }
        public Editor Editor { get; set; }

        public Caretaker(Editor editor) { 
            Editor = editor;
            BackupList = new List<Memento>();
        }
        public void MakeBackup() {
            BackupList.Add(Editor.CreateMemento());
        }

        public void Undo() {
            if(BackupList.Count > 0) {
                BackupList.Last().Restore();
                BackupList.Remove(BackupList.Last());
            } else {
                Console.WriteLine("Impossible de revenir en arriere");
            }
        }
    }
}
