using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.IO;

namespace Duplica
{

    public partial class DuplicaForm : Form
    {
        private FileGrabber.FileGrabber grabber;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public DuplicaForm()
        {
            InitializeComponent();
            pathsDescriptionBox.AppendText("Wählen Sie bitte hier die Pfade, welche nach Duplikaten durchsucht werden sollen.");
            skipPathsDescriptionBox.AppendText("Wählen Sie hier bitte die Pfade, welche von der Suche nach Duplikaten ausgeschlossen werden sollen.");
        }

        private void Duplica_Load(object sender, EventArgs e)
        {
            duplicateLister.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        void duplicateFinder_DuplicateFinderFinished(object sender, DuplicateFinder.DuplicateFinderFinishedEventArgs e)
        {
            duplicateLister.InvokeIfRequired(() =>
            {
                duplicateLister.Items.Clear();
                Dictionary<string, FileInfo[]> duplicateFiles = e.DuplicateFiles.OrderByDescending(duplicateFile => duplicateFile.Value[1].Length).ToDictionary(duplicateFile => duplicateFile.Key, duplicateFile => duplicateFile.Value);
                foreach (KeyValuePair<string, FileInfo[]> sameFiles in duplicateFiles)
                {
                    ListViewGroup hashFilesGroup = new ListViewGroup("Grösse: " + sameFiles.Value[1].Length.ToString("#,0.00 KB"));
                    foreach (FileInfo duplicateFile in sameFiles.Value)
                    {
                        ListViewItem duplicateFileItem = new ListViewItem(new string[] { duplicateFile.Name, ((float)duplicateFile.Length / 1024f).ToString("#,0.00 KB"), duplicateFile.FullName });
                        /* ToDo: Anpassung je nach Dateigrösse */
                        hashFilesGroup.Items.Add(duplicateFileItem);
                    }
                    foreach (ListViewItem fileItem in hashFilesGroup.Items)
                        duplicateLister.Items.Add(fileItem);
                    duplicateLister.Groups.Add(hashFilesGroup);
                }
                duplicateLister.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
#if !DEBUG
                duplicateLister.SetGroupState(CustomForms.ListViewGroupState.Collapsible);
#endif
            });
            okButton.InvokeIfRequired(() => okButton.Enabled = true);
        }

        private void duplicateLister_MouseDown(object sender, MouseEventArgs e)
        {
            if ((e.Button == MouseButtons.Left) && e.Clicks < 2)
            {
                List<string> files = new List<string>();
                foreach (ListViewItem selectedItem in (sender as ListView).SelectedItems)
                    files.Add(selectedItem.SubItems[(sender as ListView).Columns["fullPath"].Index].Text);
                (sender as ListView).DoDragDrop(new DataObject(DataFormats.FileDrop, files.ToArray()), DragDropEffects.Copy);
            }
            else if (e.Clicks >= 2 && e.Button == MouseButtons.Left)
                OpenSelectedEntry(sender, EventArgs.Empty);
        }

        private void OpenSelectedEntry(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem)
                sender = (((sender as ToolStripMenuItem).Owner as ContextMenuStrip).SourceControl as ListView);
            foreach (ListViewItem selectedItem in (sender as ListView).SelectedItems)
                Process.Start(selectedItem.SubItems[(sender as ListView).Columns["fullPath"].Index].Text);
        }

        private void kopierenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringCollection files = new StringCollection();

            sender = (((sender as ToolStripMenuItem).Owner as ContextMenuStrip).SourceControl as ListView);
            foreach (ListViewItem selectedItem in (sender as ListView).SelectedItems)
                files.Add(selectedItem.SubItems[(sender as ListView).Columns["fullPath"].Index].Text);
            Clipboard.SetFileDropList(files);
        }

        private void addPathButton_Click(object sender, EventArgs e)
        {
            if (choosePathDialog.ShowDialog() == DialogResult.OK)
                if (
                    !pathsListBox.Items.Contains(choosePathDialog.SelectedPath) &&
                    !skipPathsListBox.Items.Contains(choosePathDialog.SelectedPath)
                   )
                    pathsListBox.Items.Add(choosePathDialog.SelectedPath);
        }

        private void removePathButton_Click(object sender, EventArgs e)
        {
            pathsListBox.Items.Remove(pathsListBox.SelectedItem);
        }

        private void addSkipPathButton_Click(object sender, EventArgs e)
        {
            if (choosePathDialog.ShowDialog() == DialogResult.OK)
                if (
                    !pathsListBox.Items.Contains(choosePathDialog.SelectedPath) &&
                    !skipPathsListBox.Items.Contains(choosePathDialog.SelectedPath)
                   )
                    skipPathsListBox.Items.Add(choosePathDialog.SelectedPath);
        }

        private void removeSkipPathButton_Click(object sender, EventArgs e)
        {
            skipPathsListBox.Items.Remove(skipPathsListBox.SelectedItem);
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            (sender as Button).Enabled = false;
            grabber = new FileGrabber.FileGrabber
            (
                pathsListBox.Items.Cast<string>().ToArray(),
                skipPathsListBox.Items.Cast<string>().ToArray()
            );
            grabber.FileGrabberFinished += new FileGrabber.FileGrabberFinishedEventHandler(grabber_FileGrabberFinished);
            grabber.GrabFiles();
        }

        private void grabber_FileGrabberFinished(object sender, FileGrabber.FileGrabberFinishedEventArgs e)
        {
            DuplicateFinder.DuplicateFinder duplicateFinder = new DuplicateFinder.DuplicateFinder(e.GrabbedFiles);

            duplicateFinder.DuplicateFinderFinished += duplicateFinder_DuplicateFinderFinished;
            duplicateFinder.Start();
        }
    }
}
