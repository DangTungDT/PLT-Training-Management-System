using System;
using DTO;
using DAL;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class FileBLL
    {
        public bool UpdateFile(FilesDTO file)
        {
            FileDAL fileDAL = new FileDAL();
            return fileDAL.UpdateFile(file);
        }
        public List<FilesDTO> GetFiles()
        {
            FileDAL fileDAL = new FileDAL();
            return fileDAL.GetAllFiles();
        }

        public FilesDTO GetFileById(int fileId)
        {
            FileDAL fileDAL = new FileDAL();
            return fileDAL.GetFileById(fileId);
        }


        public bool AddNewFile(FilesDTO file)
        {
            FileDAL fileDAL = new FileDAL();
            return fileDAL.AddNewFile(file);
        }
    }
}
