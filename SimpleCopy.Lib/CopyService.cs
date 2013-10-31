using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCopy.Lib
{
    public class CopyService
    {
        private string _destinationRoot;

        public void CopyDirectory(string source, string destination)
        {
            //as we're going to reuse this, check inputs
            if (string.IsNullOrEmpty(source))
                throw new ArgumentException("Source cannot be empty");

            if (string.IsNullOrEmpty(destination))
                throw new ArgumentException("Destination cannot be empty");

            foreach (var directory in Directory.GetDirectories(destination))
            {
                if (Directory.Exists(directory))
                    throw new Exception(string.Format("The destination already contains a directory called {0} which would be overwritten", directory));
            }

            _destinationRoot = destination;

            //Root files
            foreach (var file in Directory.GetFiles(source))
            {
                string destinationFile = Path.Combine(destination, Path.GetFileName(file));
                File.Copy(file, destinationFile);
            }

            //this needs to be recursive.
            CopyRecursively(source);
        }

        private void CopyRecursively(string source)
        {
            foreach (var directory in Directory.GetDirectories(source))
            {
                //hack - we only want the names
                string cleanDirectory = directory.Replace(source + @"\", "");

                string destinationPath = Path.Combine(_destinationRoot, cleanDirectory);

                Directory.CreateDirectory(destinationPath);

                foreach (var file in Directory.GetFiles(directory))
                {
                    string destinationFile = Path.Combine(destinationPath, Path.GetFileName(file));
                    File.Copy(file, destinationFile);
                }

                CopyRecursively(directory);
            }
        }
    }
}
