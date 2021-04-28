using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileNameEditor
{
    class FileRenamer
    {
        private const string _path = @"c:\users\janpp\desktop\renamealbum";
        //string _path = Directory.GetCurrentDirectory();

        public void ShowDirectoryContent()
        {
            var fileEntries = Directory.GetFiles(_path);

            var fileDtos = new List<FileDto>();

            foreach (var fileName in fileEntries)
            {
                var fileDate = File.GetCreationTime(fileName);
                var fileNameWithNoPath = Path.GetFileName(fileName);
                //Console.WriteLine(fileNameWithNoPath + "||" + fileDate);

                var fileDto = new FileDto()
                {
                    FileName = fileNameWithNoPath,
                    FileCreatedDate = fileDate
                };

                fileDtos.Add(fileDto);
            }
        }
    }
}
