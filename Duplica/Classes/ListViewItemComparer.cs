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
        public int Column { get; private set; }
        public SortOrder Sorting { get; private set; }

        public ListViewItemComparer()
        {
            Column = 0;
        }
        public ListViewItemComparer(int column, SortOrder sorting)
        {
            Column = column;
            this.Sorting = sorting;
        }

        public int Compare(object x, object y)
        {
            return string.Compare(getValue(x as ListViewItem), getValue(y as ListViewItem)) * ((Sorting != SortOrder.Descending) ? 1 : -1);
        }

        private string getValue(ListViewItem listViewItem)
        {
            if (listViewItem.Tag != null)
                return listViewItem.Tag.ToString();
            else
                return listViewItem.Text;
        }
    }
}
