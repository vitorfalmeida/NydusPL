using NydusPL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NydusPL.Service
{
    public interface IHistoricoCargoService
    {
        HistoricoCargo GetById(int id);
        IEnumerable<HistoricoCargo> GetAll();
        void Create(HistoricoCargo historicoCargo);
        void Update(HistoricoCargo historicoCargo);
        void Delete(int id);
        // Adicione outros métodos específicos, se necessário
    }
}
