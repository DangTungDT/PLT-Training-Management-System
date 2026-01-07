using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
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
        private static string GetConnectionString()
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false)
                .Build();

            return config.GetConnectionString("Default");
        }
        public static bool CanConnect()
        {
            try
            {
                using var conn = new SqlConnection(GetConnectionString());
                conn.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}