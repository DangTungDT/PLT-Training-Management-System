using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BookFileDTO
    {
        public int BookId { get; set; }
        public BookDTO Book { get; set; }
        public int FileId { get; set; }
        public FilesDTO File { get; set; }

    }
}
