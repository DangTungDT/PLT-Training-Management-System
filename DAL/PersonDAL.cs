using System;
using DTO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PersonDAL
    {
        public string GetPersonNameById(int personId)
        {
            using(var context = new databaseContext.AppDBContext())
            {
                var person = context.Persons.FirstOrDefault(p => p.Id == personId);
                return person != null ? person.FullName : "";
            }
        }
    }
}
