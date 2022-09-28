using LegacyXSystem.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegacyXSystem.DAL
{
    internal partial class legacyXContext : DbContext
    {
        public virtual DbSet<SingleCalculation> SingleCalculations { get; set; }
    }
}
