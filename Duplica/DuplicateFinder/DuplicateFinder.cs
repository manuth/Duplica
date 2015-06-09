using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using System.Collections;

namespace Duplica.DuplicateFinder
{
    public class DuplicateFinder
    {
        private FileInfo[] files;
        private Hashtable hashedFiles = new Hashtable(new Dictionary<string, List<string>>());
        private Dictionary<string, FileInfo[]> duplicateFiles = new Dictionary<string, FileInfo[]>();

        public event DuplicateFinderFileProgressedEventHandler DuplicateFinderFileProgressed;
        public event DuplicateFinderFinishedEventHandler DuplicateFinderFinished;

        public DuplicateFinder(FileInfo[] files)
        {
            this.files = new List<FileInfo>(files).ToArray();
        }

        public void Start()
        {
#if DEBUG
            start();
#else
            Thread duplicateFinder = new Thread(new ThreadStart(start));
            duplicateFinder.Start();
#endif
        }

        private void start()
        {
            removeFilesByLengths();
            findDuplicates();
            OnDuplicateFinderFinished();
        }

        private void removeFilesByLengths()
        {
            Hashtable fileLengths = new Hashtable(new Dictionary<long, int>());
            List<long> fileLengthsToRemove = new List<long>();
            int fileCount = files.Length;
            FileInfo[] tmpFileList = files.ToArray();

            foreach (FileInfo file in files)
            {
                if (fileLengths.ContainsKey(file.Length))
                    fileLengths[file.Length] = (int)fileLengths[file.Length] + 1;
                else
                    fileLengths.Add(file.Length, 1);
            }
            files = null;
            foreach (DictionaryEntry fileLength in fileLengths)
                if ((int)fileLength.Value == 1)
                    fileLengthsToRemove.Add((long)fileLength.Key);
            files = new FileInfo[(tmpFileList.Length - fileLengthsToRemove.Count)];
            for (int i = 0, j = 0; i < fileCount; i++)
                if (!fileLengthsToRemove.Contains(tmpFileList[i].Length))
                    files[j++] = tmpFileList[i];
        }

        private void findDuplicates()
        {
            foreach (FileInfo file in files)
            {
                FileHasher hasher = new FileHasher(file.FullName, 7 * 1024 * 1024);
                hasher.Progressed += hasher_Progressed;

                string fileHash = hasher.CalculateHash();
                if (!hashedFiles.Contains(fileHash))
                    hashedFiles.Add(fileHash, new List<string>(){ file.FullName });
                else
                    (hashedFiles[fileHash] as List<string>).Add(file.FullName);
            }
            foreach (DictionaryEntry hashedFile in hashedFiles)
            {
                int hashFileCount;
                if ((hashFileCount = (hashedFile.Value as List<string>).Count) != 1)
                {
                    string fileHash = (string)hashedFile.Key;
                    duplicateFiles.Add(fileHash, new FileInfo[hashFileCount]);
                    for (int i = 0; i < hashFileCount; i++)
                        duplicateFiles[fileHash][i] = new FileInfo((hashedFile.Value as List<string>)[i]);
                }
            }
        }

        private void hasher_Progressed(object sender, DuplicateFinderFileProgressedEventArgs e)
        {
            OnDuplicateFinderFileProgressed(e);
        }

        private void OnDuplicateFinderFinished()
        {
            if (DuplicateFinderFinished != null)
                DuplicateFinderFinished(this, new DuplicateFinderFinishedEventArgs(duplicateFiles));
        }

        private void OnDuplicateFinderFileProgressed(DuplicateFinderFileProgressedEventArgs e)
        {
            if (DuplicateFinderFileProgressed != null)
                DuplicateFinderFileProgressed(this, e);
        }
    }
}
