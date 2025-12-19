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
    }
}
