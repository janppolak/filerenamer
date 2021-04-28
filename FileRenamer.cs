using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FileNameEditor
{
    class FileRenamer
    {
        private readonly string _directoryPath;

        public FileRenamer(string directoryPath)
        {
            _directoryPath = directoryPath;
        }

        public List<FileDto> GetFileDtosFromDirectory()
        {
            var fileEntries = Directory.GetFiles(_directoryPath);

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
            return fileDtos;
        }

        internal void RenameFiles(List<FileDto> fileDtos)
        {
            var sortedFileDtos = fileDtos.OrderBy(dto => dto.FileCreatedDate).ToList();
            for (int i = 0; i < sortedFileDtos.Count; i++)
            {
                RenameFile(i + 1, sortedFileDtos[i]);
            }
        }

        private void RenameFile(int id, FileDto fileDto)
        {
            var newFileName = GetNewFileName(id, fileDto);
            var oldFileNameWithPath = Path.Combine(_directoryPath, fileDto.FileName);
            var extension = Path.GetExtension(oldFileNameWithPath);
            var newFileNameWithPath = Path.Combine(_directoryPath, newFileName + extension);

            Console.WriteLine("Renaming: " + oldFileNameWithPath + " => " + newFileNameWithPath);
            File.Move(oldFileNameWithPath, newFileNameWithPath);
        }

        private string GetNewFileName(int id, FileDto fileDto)
        {
            var dateString = fileDto.FileCreatedDate.ToString("G").Replace(':', '.');
            return $"{id} - {dateString}";
        }
    }
}
