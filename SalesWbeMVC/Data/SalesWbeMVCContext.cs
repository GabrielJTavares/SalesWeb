using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWbeMVC.Models;

namespace SalesWbeMVC.Data
{
    public class SalesWbeMVCContext : DbContext
    {
        public SalesWbeMVCContext (DbContextOptions<SalesWbeMVCContext> options)
            : base(options)
        {
        }

        public DbSet<Departament> Departament { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecords { get; set; }
    }
}
