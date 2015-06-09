using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Threading;
using System.IO;

namespace Duplica.DuplicateFinder
{
    public class FileHasher
    {
        private string filePath;
        private int chunkSize;
        private MD5 fileHasher;

        public event DuplicateFinderFileProgressedEventHandler Progressed;

        public FileHasher(string filePath, int chunkSize)
        {
            this.filePath = filePath;
            this.chunkSize = chunkSize;
            fileHasher = new MD5CryptoServiceProvider();
        }

        public string CalculateHash()
        {
            string output = "";
            using (Stream _fileReader = File.OpenRead(filePath))
            {
                byte[] chunk = new byte[chunkSize];
                int readSize;
                while ((readSize = _fileReader.Read(chunk, 0, chunkSize)) == chunkSize)
                {
                    fileHasher.TransformBlock(chunk, 0, readSize, chunk, 0);
                    OnProgressed(new DuplicateFinderFileProgressedEventArgs((float)_fileReader.Position / (float)_fileReader.Length * 100f, filePath));
                }
                fileHasher.TransformFinalBlock(chunk, 0, readSize);
                OnProgressed(new DuplicateFinderFileProgressedEventArgs(100f, filePath));
            }
            foreach (byte hashByte in fileHasher.Hash)
                output += hashByte.ToString("X2");
            return output;
        }

        private void OnProgressed(DuplicateFinderFileProgressedEventArgs e)
        {
            if (Progressed != null)
                Progressed(this, e);
        }
    }
}
