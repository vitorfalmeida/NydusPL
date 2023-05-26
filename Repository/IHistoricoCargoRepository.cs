using NydusPL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NydusPL.Repository
{
    public interface IHistoricoCargoRepository : IRepository<HistoricoCargo>
    {
        IEnumerable<HistoricoCargo> GetByColaboradorId(int colaboradorId);
        IEnumerable<HistoricoCargo> GetByCargoId(int cargoId);
        IEnumerable<HistoricoCargo> GetByPeriodo(DateTime dataInicio, DateTime dataFim);
    }


}
