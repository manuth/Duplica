using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duplica.DuplicateFinder
{    
    public class DuplicateFinderFileProgressedEventArgs
    {
        private float filePercentage;
        private string filePath;

        public float Percentage { get { return filePercentage; } }
        public string FilePath { get { return filePath; } }

        public DuplicateFinderFileProgressedEventArgs(float filePercentage, string filePath)
        {
            this.filePercentage = filePercentage;
            this.filePath = filePath;
        }
    }

    public delegate void DuplicateFinderFileProgressedEventHandler(object sender, DuplicateFinderFileProgressedEventArgs e);
}
