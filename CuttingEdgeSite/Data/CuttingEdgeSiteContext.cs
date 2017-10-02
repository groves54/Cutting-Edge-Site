using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CuttingEdgeSite.Models
{
    public class CuttingEdgeSiteContext : DbContext
    {
        public CuttingEdgeSiteContext (DbContextOptions<CuttingEdgeSiteContext> options)
            : base(options)
        {
        }

        public DbSet<CuttingEdgeSite.Models.Product> Product { get; set; }
    }
}
