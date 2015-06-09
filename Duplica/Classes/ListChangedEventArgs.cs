using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Duplica
{
    /// <summary>
    /// Beinhaltet nötige Eigenschaften, um die Änderungen an einer Auflistung zu definieren.
    /// </summary>
    public class ListChangedEventArgs : EventArgs
    {
        /// <summary>
        /// Gibt den Start-Index zurück, ab dem an der Auflistung Änderungen vorgenommen wurde
        /// oder -1, falss dieser nicht definierbar ist.
        /// </summary>
        public int StartIndex { get { return startIndex; } }
        /// <summary>
        /// Gibt den End-Index zurück, ab dem an der Auflistung Änderungen vorgenommen wurde
        /// oder -1, falss dieser nicht definierbar ist.
        /// </summary>
        public int EndIndex { get { return endIndex; } }

        /// <summary>
        /// Gibt den Start-Index der Änderungen zurück oder legt diesen Fest.
        /// </summary>
        private int startIndex;
        /// <summary>
        /// Gibt den End-Index der Änderungen zurück oder legt diesen Fest.
        /// </summary>
        private int endIndex;

        /// <summary>
        /// Initialisiert ein neues Objekt, welches zum definieren von Änderungen einer Auflistung verwendet wird.
        /// </summary>
        public ListChangedEventArgs(int startIndex, int endIndex)
        {
            this.startIndex = startIndex;
            this.endIndex = endIndex;
        }
    }

    /// <summary>
    /// Stellt eine Methode dar, welche das Ereignis "ListChanged" behandelt.
    /// </summary>
    public delegate void ListChangedEventHandler(object sender, ListChangedEventArgs e);
}
