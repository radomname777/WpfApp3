using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    public class AppContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public AppContext()
        {
            Database.EnsureCreated();
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=STHQ0116-04;Initial Catalog=MyStudentsDB;User ID=admin;Password=admin;TrustServerCertificate=True");
        }
    }
}
