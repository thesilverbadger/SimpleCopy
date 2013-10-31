using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCopy.Lib
{
    public class FileCopyEventArgs : EventArgs
    {
        public string FileName { get; private set; }

        public FileCopyEventArgs(string fileName)
        {
            FileName = fileName;
        }
    }
}
