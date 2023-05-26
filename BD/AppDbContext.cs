using NydusPL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NydusPL.BD
{
    public class AppDbContext : DbContext, IAppDbContext
    {
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Cargo> Cargos { get; set; }
        public DbSet<Colaborador> Colaboradores { get; set; }
        public DbSet<HistoricoCargo> HistoricoCargos { get; set; }

        public AppDbContext() : base("name=DefaultConnection")
        {
        }
    }
}