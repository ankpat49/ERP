using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ERP.Models;

namespace ERP.Data
{
    public class ERPContext : DbContext
    {
        public ERPContext (DbContextOptions<ERPContext> options)
            : base(options)
        {
        }

        public DbSet<ERP.Models.Products> Products { get; set; }
    }
}
