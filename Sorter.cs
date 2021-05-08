using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FileNameEditor
{
    class Sorter
    {
        public string _path = @"c:\users\janpp\desktop\żółw";

        public List<FileDto> GetFileDtos()
        {
            var fileEntries = Directory.GetFiles(_path);
            var fileDtoss = new List<FileDto>();
            

            foreach (var item in fileEntries)
            {
                var fileName = Path.GetFileName(item);

                var FileDto = new FileDto()
                {
                    FileName = fileName
                };
                fileDtoss.Add(FileDto);
            }
            return fileDtoss;
        }
        public void ListSorter(List<FileDto> fileDtoss)
        {
            var sortedList = fileDtoss.OrderBy(x => x.FileName).ToList();

            foreach (var item in sortedList)
            {
                Console.WriteLine(item.FileName);
            }
        }
    }
}
