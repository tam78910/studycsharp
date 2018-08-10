using System;
using Microsoft.EntityFrameworkCore;

namespace Movie.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("server=localhost,1433;user=sa;password=reallyStrongPwd123;database=Movie");
            base.OnConfiguring(builder);
        }

       
       
    }
}
