using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;
using System.Threading;

namespace Duplica.FileGrabber
{
    public class FileGrabber
    {
        private DirectoryInfo[] folderPaths;
        private DirectoryInfo[] skipFolderPaths;
        private List<FileInfo> allFiles = new List<FileInfo>();

        public event FileGrabberFinishedEventHandler FileGrabberFinished;

        public FileGrabber(string[] folderPaths, string[] skipFolderPaths)
        {
            this.folderPaths = new DirectoryInfo[folderPaths.Length];
            for (int i = 0; i < folderPaths.Length; i++)
                this.folderPaths[i] = new DirectoryInfo(folderPaths[i]);
            this.skipFolderPaths = new DirectoryInfo[skipFolderPaths.Length];
            for (int i = 0; i < skipFolderPaths.Length; i++)
                this.skipFolderPaths[i] = new DirectoryInfo(skipFolderPaths[i]);
        }

        public void GrabFiles()
        {
#if DEBUG
            grabFiles();
#else
            Thread GrabThread = new Thread(new ThreadStart(grabFiles));
            GrabThread.Name = "Duplica FileGrabber";
            GrabThread.IsBackground = true;
            GrabThread.Start();
#endif
        }

        private void grabFiles()
        {
            foreach (DirectoryInfo folderPath in folderPaths)
            {
                browseFolders(folderPath);
            }
            OnFileGrabberFinished();
        }

        private void scanFiles(DirectoryInfo dir)
        {
            try
            {
                foreach (FileInfo file in dir.GetFiles())
                {
                    /* ToDo: Codezeilen zum Überspringen von Dateigrössen hinzufügen */
                    allFiles.Add(file);
                }
            }
            catch { }
        }

        private void browseFolders(DirectoryInfo dir)
        {
            /* ToDo: Variable zum weglassen des Papierkorb-Ordners einfügen */
            if (!dir.FullName.Remove(0, 1).ToUpper().StartsWith(@":\$RECYCLE.BIN"))
            {
                scanFiles(dir);
                DirectoryInfo[] subDirs = new DirectoryInfo[] { };
                try
                {
                    subDirs = dir.GetDirectories();
                }
                catch { }
                foreach (DirectoryInfo subDir in subDirs)
                {
                    if (!skipFolderPaths.Any(skipFolder => skipFolder.FullName == subDir.FullName))
                        browseFolders(subDir);
                    /* ToDo: Event bei Wechseln eines Ordners Einfügen */
                }
            }
        }

        private void OnFileGrabberFinished()
        {
            if (FileGrabberFinished != null)
                FileGrabberFinished(this, new FileGrabberFinishedEventArgs(this.allFiles.ToArray()));
        }
    }
}
