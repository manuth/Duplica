﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Collections.Specialized;

namespace Duplica.CustomForms
{
    /// <summary>
    /// Stellt eine ListView dar, welche den Windows Explorer-Look hat.
    /// Zudem passt er die Grösse der Spalten bei jeder Änderung der Auflistung automatisch an.
    /// </summary>
    public partial class CustomListView
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("uxtheme", CharSet = CharSet.Unicode)]
        private static extern int SetWindowTheme(IntPtr hWnd, string textSubAppName, string textSubIdList);

        private const int WM_CHANGEUISTATE = 0x127;
        private const int UIS_SET = 1;
        private const int UISF_HIDEFOCUS = 0x1;

        new public WatchedListViewItemCollection Items;

        /// <summary>
        /// Kreiert eine CustomListView mit der Detail-Ansicht und dem Windows Explorer-Look
        /// </summary>
        public CustomListView() : base()
        {
            this.Items = new WatchedListViewItemCollection(this);
            this.Items.ListChanged += new ListChangedEventHandler(Items_ListChanged);
            this.HandleCreated += new EventHandler(CustomListView_HandleCreated);
            this.ColumnClick += CustomListView_ColumnClick;
            this.View = View.Details;
            this.FullRowSelect = true;

            //Entfernt die gepunktete Linie um das ausgewählte Item
            SendMessage(this.Handle, WM_CHANGEUISTATE, makeLong(UIS_SET, UISF_HIDEFOCUS), 0);
        }

        private void CustomListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            bool reversed = false;
            if ((ListViewItemSorter is ListViewItemComparer) && (ListViewItemSorter as ListViewItemComparer).Col == e.Column)
                if (!(ListViewItemSorter as ListViewItemComparer).Reversed)
                    reversed = true;
            ListViewItemSorter = new ListViewItemComparer(e.Column, reversed);
            this.Sort();
        }

        /// <summary>
        /// Passt bei Änderung der "Items"-Auflistung die Breite des Spalten an.
        /// </summary>
        private void Items_ListChanged(object sender, ListChangedEventArgs e)
        {
#if !DEBUG
            this.SetGroupState(ListViewGroupState.Collapsible);
#endif
        }

        /// <summary>
        /// Legt das Windows Explorer-Design fest
        /// </summary>
        public void CustomListView_HandleCreated(object sender, EventArgs e)
        {
            SetWindowTheme(this.Handle, "explorer", null);
        }

        private int makeLong(int wLow, int wHigh)
        {
            int low = (int)intLoWord(wLow);
            short high = intLoWord(wHigh);
            int product = 0x10000 * (int)high;
            int mkLong = (int)(low | product);
            return mkLong;
        }

        private short intLoWord(int word)
        {
            return (short)(word & short.MaxValue);
        }

    }
}
