using System;

namespace FileNameEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            const string path = @"c:\users\janpp\desktop\renamealbum";
            //string path = Directory.GetCurrentDirectory();

            var fileRenamer = new FileRenamer(path);
            var fileDtos = fileRenamer.GetFileDtosFromDirectory();
            fileRenamer.RenameFiles(fileDtos);
        }
    }
}
