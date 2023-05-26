using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NydusPL.Models
{
    public class HistoricoCargo
    {
        public int Id { get; set; }
        public DateTime DataInicioVigencia { get; set; }

        public int ColaboradorId { get; set; }
        public Colaborador Colaborador { get; set; }

        public int CargoId { get; set; }
        public Cargo Cargo { get; set; }
        public DateTime DataInicio { get; internal set; }
        public DateTime DataFim { get; internal set; }
    }

}