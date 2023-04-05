using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.entities.Patterns.MementoGuru {
    public class Editor { // Originator
        public string Text { get; set; }
        public int CurX { get; set; }
        public int CurY { get; set; }
        public int SelectionWidth { get; set; }

        public Memento CreateMemento() {
            return new Memento(this, Text, CurX, CurY, SelectionWidth);
        }

        public void Show() {
            Console.WriteLine("Cursor : " + CurX + "," + CurY + " Text : " + Text + " SelectionWidth : " + SelectionWidth);
        }
    }
}
