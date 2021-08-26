using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SistemaWebVuelos.Models;

namespace SistemaWebVuelos.Data
{
    public class DbVueloContext : DbContext
    {
        public DbVueloContext(DbContextOptions<DbVueloContext> options) : base(options) { }

        public DbSet<Vuelo> Vuelos { get; set; }
    }
}
