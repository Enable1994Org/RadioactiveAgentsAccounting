using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioactiveAgentsAccounting.Models
{
    public class DataContext : DbContext
    {
        public DbSet<Institution> Institutions { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<InstRawAmount> InstRawAmounts { get; set; }
        public DbSet<InstIrsAmount> InstIrsAmounts { get; set; }
        public DbSet<RAW> Raws { get; set; }
        public DbSet<RAWType> RawTypes { get; set; }
        public DbSet<IRS> Irss { get; set; }
    }
}
