using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileNameEditor
{
    class DirectoryContentInfo
    {
        //private const string _path = @"c:\users\janpp\desktop\renamealbum";
        string _path = Directory.GetCurrentDirectory();

        public void ShowDirectoryContent()
        {
            string[] fileEntries = Directory.GetFiles(_path);

            foreach (var fileName in fileEntries)
            {  
                DateTime[] dateTimes = { File.GetCreationTime(fileName) };
                foreach (var fileDate in dateTimes)
                {
                    Console.WriteLine(fileName + "||" + fileDate);
                }
            }

            //collection1.Concat(collection2); 
            //collection1.select(x => (baseType)x).Concat(collection2.select(x => (baseType)x));

        }
    }
}
