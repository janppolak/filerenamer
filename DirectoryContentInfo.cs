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
            foreach (var fileName in fileEntries)
            {  
                DateTime[] dateTimes = { Directory.GetCreationTime(_path) };
                foreach (var fileDate in dateTimes)
                {
                    Console.WriteLine(fileName + "||" + fileDate);
                }
            }

            

        }
    }
}
