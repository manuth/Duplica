using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Duplica
{
    public class ListViewItemComparer : IComparer
    {
        public int Col { get; private set; }
        public bool Reversed { get; private set; }
        public ListViewItemComparer()
        {
            Col = 0;
        }
        public ListViewItemComparer(int column, bool reversed)
        {
            Col = column;
            this.Reversed = reversed;
        }
        public int Compare(object x, object y)
        {
            return String.Compare(((ListViewItem)x).SubItems[Col].Text, ((ListViewItem)y).SubItems[Col].Text) * (Reversed ? -1 : 1);
        }
    }
}
