using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MKVSort
{
    public class FileInfo
    {
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public bool Selected { get; set; }

        public FileInfo(string file)
        {
            FileName = Path.GetFileName(file);
            FilePath = Path.GetDirectoryName(file);
            Selected = false;
        }
    }
}
