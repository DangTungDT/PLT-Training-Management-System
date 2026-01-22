using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class RoomBLL
    {
        private  RoomDAL _dal = new RoomDAL();
        public RoomDTO GetById(int id)
        {
            return _dal.GetById(id);
        }
    }
}
