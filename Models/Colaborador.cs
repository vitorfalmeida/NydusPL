using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NydusPL.Models
{
    public class Colaborador
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Matricula { get; set; }
        public DateTime DataAdmissao { get; set; }
        public DateTime? DataDemissao { get; set; }

        public ICollection<HistoricoCargo> HistoricoCargos { get; set; }
        public int EmpresaId { get; set; }
        public Empresa Empresa { get; set; }
    }

}