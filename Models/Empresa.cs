using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NydusPL.Models
{
    public class Empresa
    {
        public int Id { get; set; }
        public string CNPJ { get; set; }
        public string Cnpj { get; internal set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }

        public ICollection<Colaborador> Colaboradores { get; set; }
        public ICollection<Cargo> Cargos { get; set; }
    }


}