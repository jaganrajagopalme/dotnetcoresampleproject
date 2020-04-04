using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspnetCoreSampleProject.Models;

namespace AspnetCoreSampleProject.Mock
{
    public class AppcontextDb:DbContext
    {
        public AppcontextDb(DbContextOptions<AppcontextDb> options):base (options)
        {
           

        }

        public DbSet<Computers> Computers { get; set; }
    }
}
