using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PersonDTO
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Address { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public ICollection<BookDTO> Books { get; set; }
        public ICollection<AccountDTO> Accounts { get; set; }
        public ICollection<StudentDTO> Students { get; set; }
        public ICollection<TeacherDTO> Teachers { get; set; }
    }
}
