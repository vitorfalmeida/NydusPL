using NydusPL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NydusPL.BD
{
    public interface IAppDbContext
    {
        DbSet<Empresa> Empresas { get; set; }
        DbSet<Cargo> Cargos { get; set; }
        DbSet<Colaborador> Colaboradores { get; set; }
        DbSet<HistoricoCargo> HistoricoCargos { get; set; }
        int SaveChanges();
    }
}
