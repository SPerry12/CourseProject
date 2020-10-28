using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CookBookPlus5000.Models;

namespace CookBookPlus5000.Data
{
    public class CookBookPlus5000Context : DbContext
    {
        public CookBookPlus5000Context (DbContextOptions<CookBookPlus5000Context> options)
            : base(options)
        {
        }

        public DbSet<CookBookPlus5000.Models.Recipe> Recipe { get; set; }
    }
}
