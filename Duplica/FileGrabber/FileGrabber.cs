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
        private List<FileInfo> allFiles;
        private long minFileSize;
        private long maxFileSize;
        private bool minFileSizeFilter;
        private bool maxFileSizeFilter;

        public event FileGrabberFinishedEventHandler FileGrabberFinished;

        public FileGrabber(string[] folderPaths, string[] skipFolderPaths, long maxFileSize, bool maxFileSizeFilter, long minFileSize, bool minFileSizeFilter) : this(folderPaths, skipFolderPaths)
        {
            this.minFileSize = minFileSize;
            this.minFileSizeFilter = minFileSizeFilter;
            this.maxFileSize = maxFileSize;
            this.maxFileSizeFilter = maxFileSizeFilter;
        }

        public FileGrabber(string[] folderPaths, string[] skipFolderPaths)
        {
            minFileSizeFilter = false;
            maxFileSizeFilter = false;
            allFiles = new List<FileInfo>();

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
                    if (
                        (!minFileSizeFilter || file.Length > minFileSize) &&
                        (!maxFileSizeFilter || file.Length < maxFileSize))
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
                    {
                        /* ToDo: Event bei Wechseln eines Ordners Einfügen */
                        browseFolders(subDir);
                    }
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
