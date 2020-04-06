using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPageMVCSampleProject.Model
{
    public class Appcontextdb : DbContext
    {
        public Appcontextdb(DbContextOptions<Appcontextdb> options) : base(options)
        {

        }

        public DbSet<Books> Books {get;set;}
    }
}
