using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Duplica
{
    public class WatchedListViewItemCollection : ListView.ListViewItemCollection
    {
        public event ListChangedEventHandler ListChanged;

        public WatchedListViewItemCollection(ListView owner) : base(owner)
        { }

        new public void Add(ListViewItem value)
        {
            base.Add(value);
            OnListChanged(this.Count - 1);
        }

        new public void Add(string text)
        {
            base.Add(text);
            OnListChanged(this.Count - 1);
        }

        new public void Add(string text, int imageIndex)
        {
            base.Add(text, imageIndex);
            OnListChanged(this.Count - 1);
        }

        new public void Add(string text, string imageKey)
        {
            base.Add(text, imageKey);
            OnListChanged(this.Count - 1);
        }

        new public void Add(string key, string text, int imageIndex)
        {
            base.Add(key, text, imageIndex);
            OnListChanged(this.Count - 1);
        }

        new public void Add(string key, string text, string imageKey)
        {
            base.Add(key, text, imageKey);
            OnListChanged(this.Count - 1);
        }

        new public void AddRange(ListView.ListViewItemCollection items)
        {
            int startIndex = this.Count;
            base.AddRange(items);
            OnListChanged(startIndex, this.Count - 1);
        }

        new public void AddRange(ListViewItem[] items)
        {
            int startIndex = this.Count;
            base.AddRange(items);
            OnListChanged(startIndex, this.Count - 1);
        }

        new public void Clear()
        {
            base.Clear();
            OnListChanged();
        }

        new public void Insert(int index, ListViewItem value)
        {
            base.Insert(index, value);
            OnListChanged(index);
        }

        new public void Insert(int index, string text)
        {
            base.Insert(index, text);
            OnListChanged(index);
        }

        new public void Insert(int index, string text, int imageIndex)
        {
            base.Insert(index, text, imageIndex);
            OnListChanged(index);
        }

        new public void Insert(int index, string text, string imageKey)
        {
            base.Insert(index, text, imageKey);
            OnListChanged(index);
        }

        new public void Insert(int index, string key, string text, int imageIndex)
        {
            base.Insert(index, key, text, imageIndex);
            OnListChanged(index);
        }

        new public void Insert(int index, string key, string text, string imageKey)
        {
            base.Insert(index, key, text, imageKey);
            OnListChanged(index);
        }

        new public void Remove(ListViewItem item)
        {
            base.Remove(item);
            OnListChanged();
        }

        new public void RemoveAt(int index)
        {
            base.RemoveAt(index);
            OnListChanged();
        }

        private void OnListChanged()
        {
            if (ListChanged != null)
                ListChanged(this, new ListChangedEventArgs(-1, -1));
        }

        private void OnListChanged(int index)
        {
            if (ListChanged != null)
                ListChanged(this, new ListChangedEventArgs(index, index));
        }

        private void OnListChanged(int startIndex, int endIndex)
        {
            if (ListChanged != null)
                ListChanged(this, new ListChangedEventArgs(startIndex, endIndex));
        }
    }
}
