using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using ValeAtivos324138379.Models;

namespace ValeAtivos324138379.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        
        {
            
        }
        
        public DbSet<Equipamento> Equipamentos {get ; set ;}
        
    }
}