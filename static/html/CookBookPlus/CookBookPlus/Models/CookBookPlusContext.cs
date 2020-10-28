using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CookBookPlus.Models;

namespace CookBookPlus.Models
{
    public class CookBookPlusContext : DbContext
    {
        public CookBookPlusContext(DbContextOptions<CookBookPlusContext> options)
            : base(options)
        {
        }

        public DbSet<Recipes> Recipes { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Category> Category {get; set;}
    }
}
