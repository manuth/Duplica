using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Duplica.DuplicateFinder
{
    public class DuplicateFinderFinishedEventArgs
    {
        private Dictionary<string, FileInfo[]> duplicateFiles;

        public Dictionary<string, FileInfo[]> DuplicateFiles { get { return duplicateFiles; } }

        public DuplicateFinderFinishedEventArgs(Dictionary<string, FileInfo[]> duplicateFiles)
        {
            this.duplicateFiles = duplicateFiles;
        }
    }

    public delegate void DuplicateFinderFinishedEventHandler(object sender, DuplicateFinderFinishedEventArgs e);
}
