using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstExample.Models
{
    public class SalesDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-PP0TB7N;Initial Catalog=SalesDb1;Integrated Security=True");
            }
        }
        public DbSet<Sales> Sales { get; set; }
    }
}
