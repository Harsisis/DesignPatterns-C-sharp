using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.entities.Patterns.MementoGuru {
    public class Memento {
        public Editor SavedEditor { get; set; }
        public string Text { get; set; }
        public int CurX { get; set; }
        public int CurY { get; set; }
        public int SelectionWidth { get; set; }

        public Memento(Editor savedEditor, string text, int curX, int curY, int selectionWidth) {
            SavedEditor = savedEditor;
            Text = text;
            CurX = curX;
            CurY = curY;
            SelectionWidth = selectionWidth;
        }

        public void Restore() {
            SavedEditor.CurY = CurY;
            SavedEditor.CurX = CurX;
            SavedEditor.Text = Text;
            SavedEditor.SelectionWidth = SelectionWidth;
        }
    }
}
