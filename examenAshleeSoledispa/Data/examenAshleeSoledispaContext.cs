using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using examenAshleeSoledispa.Models;

namespace examenAshleeSoledispa.Data
{
    public class examenAshleeSoledispaContext : DbContext
    {
        public examenAshleeSoledispaContext (DbContextOptions<examenAshleeSoledispaContext> options)
            : base(options)
        {
        }

        public DbSet<examenAshleeSoledispa.Models.Cliente> Cliente { get; set; } = default!;
    }
}
