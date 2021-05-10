using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FileNameEditor
{
    class Sorter
    {
        private string _path = @"c:\users\janpp\desktop\żółw";

        public List<FileDto> GetFileDtos()
        {
            var fileEntries = Directory.GetFiles(_path);
            var fileDtoss = new List<FileDto>();


            foreach (var item in fileEntries)
            {
                var fileName = Path.GetFileName(item);

                var fileDto = new FileDto()
                {
                    FileName = fileName
                };
                fileDtoss.Add(fileDto);
            }
            return fileDtoss;
        }
        public void ListSorter(List<FileDto> fileDtoss)
        {
            var sortedList = fileDtoss.OrderBy(x => x.FileName).ToList();

            for (int i = 0; i < sortedList.Count; i++)
            {
                foreach (var item in sortedList)
                {
                    Console.WriteLine(i + item.FileName);
                }
                
            }
        }
    }
}
