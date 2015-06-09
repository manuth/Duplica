using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Duplica.FileGrabber
{
    public class FileGrabberFinishedEventArgs : EventArgs
    {
        private FileInfo[] grabbedFiles;

        public FileInfo[] GrabbedFiles { get { return grabbedFiles; } }

        public FileGrabberFinishedEventArgs(FileInfo[] grabbedFiles)
        {
            this.grabbedFiles = grabbedFiles;
        }
    }

    public delegate void FileGrabberFinishedEventHandler(object sender, FileGrabberFinishedEventArgs e);
}
