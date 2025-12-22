using System;
using DTO;
using DAL;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PersonBLL
    {
        private PersonDAL _personDAL = new PersonDAL();
        public string GetPersonNameById(int personId)
        {
            return _personDAL.GetPersonNameById(personId);
        }
    }
}
