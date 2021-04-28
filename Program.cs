using System;

namespace FileNameEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            var directory = new FileRenamer();
            directory.ShowDirectoryContent();
        }
    }
}
