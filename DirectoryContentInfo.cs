using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileNameEditor
{
    class DirectoryContentInfo
    {
        private const string _path = @"c:\users\janpp\desktop\renamealbum";


        public void ShowDirectoryContent()
        {
            string[] fileEntries = Directory.GetFiles(_path);
            foreach (var item in fileEntries)
            {
                Console.WriteLine(item);
            }

        }
    }
}
