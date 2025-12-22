using System;
using DTO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class FileDAL
    {
        public List<FilesDTO> GetAllFiles()
        {
            try
            {
                using (var context = new databaseContext.AppDBContext())
                {
                    return context.Files.ToList();
                }
            }
            catch
            {
                return new List<FilesDTO>();
            }
        }

        public FilesDTO GetFileById(int fileId)
        {
            try
            {
                using (var context = new databaseContext.AppDBContext())
                {
                    return context.Files.FirstOrDefault(f => f.Id == fileId);
                }
            }
            catch
            {
                return null;
            }
        }
        public bool AddNewFile(FilesDTO file)
        {
            try
            {
                using (var context = new databaseContext.AppDBContext())
                {
                    var existing = context.Files.FirstOrDefault(f => f.FilePath == file.FilePath && f.FileName == file.FileName && f.FileSize == file.FileSize);
                    if (existing != null) return false;
                    context.Files.Add(file);
                    context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateFile(FilesDTO file)
        {
            try
            {
                using (var context = new databaseContext.AppDBContext())
                {
                    var existing = context.Files.Find(file.Id);
                    if (existing == null)
                    {
                        return AddNewFile(file);
                    }
                    existing.FileName = file.FileName;
                    existing.FilePath = file.FilePath;
                    existing.FileSize = file.FileSize;
                    context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
