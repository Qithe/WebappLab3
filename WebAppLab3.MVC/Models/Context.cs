using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppLab3.MVC.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Movie> movies { get; set; }
    }
}
