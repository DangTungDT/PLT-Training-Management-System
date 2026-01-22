using DAL.databaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class RoomDAL
    {
        private readonly AppDBContext _context = new AppDBContext();
        public RoomDTO GetById(int id)
        {
            try
            {
                var r = _context.Rooms.Find(id);
                if (r == null) return null;

                return new RoomDTO
                {
                    Id = r.Id,
                    Name = r.Name,
                    Location = r.Location,
                    Capacity = r.Capacity
                };
            }
            catch
            {
                return null;
            }
        }
    }
}
