using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NydusPL.Models
{
    public class Cargo
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CBO { get; set; }
        public string DescricaoAtividades { get; set; }

        public ICollection<HistoricoCargo> HistoricoCargos { get; set; }
    }

}