using System;

namespace FileNameEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            const string path = @"c:\users\janpp\desktop\renamealbum";
            //string path = Directory.GetCurrentDirectory();

            var hasPermission = UserHasPermissionToModifyFileNames();

            if(hasPermission == false)
            {
                Console.WriteLine("You don't have permission. Press any key to exit");
                Console.ReadKey();
                return;
            }

            var fileRenamer = new FileRenamer(path);
            var fileDtos = fileRenamer.GetFileDtosFromDirectory();
            fileRenamer.RenameFiles(fileDtos);
        }

        private static bool UserHasPermissionToModifyFileNames()
        {
            // TODO: Implement in the future
            return false;
        }
    }
}
