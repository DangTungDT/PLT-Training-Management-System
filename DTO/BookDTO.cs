using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BookDTO
    {
        public int Id { get; set; }
        public string ISBN { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int PublishedYear { get; set; }
        public string Description { get; set; }
        public string DifficultyLevel { get; set; }
        public int CategoryId { get; set; }
        public CategoryDTO Category { get; set; }
        public ICollection<BookFileDTO> BookFiles { get; set; }

    }
}
