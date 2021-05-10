using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Legion1.Models;

namespace Legion1.Data
{
     public class NumberContext : DbContext
        {
        public NumberContext(DbContextOptions options) : base(options) { }

        public DbSet<Recent> Recent { get; set; }
        
        }

    
}
