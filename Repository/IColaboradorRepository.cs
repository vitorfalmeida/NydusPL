using NydusPL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NydusPL.Repository
{
    public interface IColaboradorRepository : IRepository<Colaborador>
    {
        IEnumerable<Colaborador> GetByMatricula(string matricula);
        IEnumerable<Colaborador> GetByDataAdmissao(DateTime dataAdmissao);
        IEnumerable<Colaborador> GetByDataDemissao(DateTime dataDemissao);
    }


}
