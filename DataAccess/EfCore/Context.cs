using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EfCore
{
    public class Context:DbContext
    {
        public DbSet<tb_customer> tb_customer { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseNpgsql(@"Host=localhost;Port=5442;Username=postgres;Password=saadet2000;Database=postgres");
            optionsBuilder.UseNpgsql(@"Server=xxx;Database=xxx; Port=xxx; Ssl Mode = Disable; User Id =xxx; Password=xxx");
        }
    }
}
