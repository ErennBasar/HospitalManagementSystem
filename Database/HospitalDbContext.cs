using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagementSystem.Database
{
    public class HospitalDbContext : DbContext
    {

        /* public HospitalDbContext(DbContextOptions<HospitalDbContext> options) : base(options) 
        {
        } */


        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost\\SQLEXPRESS;Initial Catalog=HospitalManagementSystemDatabase;Integrated Security=True; Trust Server Certificate=True");
        }
        
    }
}
