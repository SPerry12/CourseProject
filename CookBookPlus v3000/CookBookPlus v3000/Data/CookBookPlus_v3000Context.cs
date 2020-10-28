using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CookBookPlus_v3000.Models;

namespace CookBookPlus_v3000.Data
{
    public class CookBookPlus_v3000Context : DbContext
    {
        public CookBookPlus_v3000Context (DbContextOptions<CookBookPlus_v3000Context> options)
            : base(options)
        {
        }

        public DbSet<CookBookPlus_v3000.Models.Recipes> Recipes { get; set; }
    }
}
