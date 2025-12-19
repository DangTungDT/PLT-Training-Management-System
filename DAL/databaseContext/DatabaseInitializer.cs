using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.databaseContext
{
    public static class DatabaseInitializer
    {
        public static void Initialize()
        {
            using (var context = new AppDBContext())
            {
                context.Database.Migrate();
            }
        }
    }
}