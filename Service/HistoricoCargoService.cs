using NydusPL.Models;
using NydusPL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NydusPL.Service
{
    public class HistoricoCargoService : IHistoricoCargoService
    {
        private readonly IHistoricoCargoRepository _historicoCargoRepository;

        public HistoricoCargoService(IHistoricoCargoRepository historicoCargoRepository)
        {
            _historicoCargoRepository = historicoCargoRepository;
        }

        public HistoricoCargo GetById(int id)
        {
            return _historicoCargoRepository.GetById(id);
        }

        public IEnumerable<HistoricoCargo> GetAll()
        {
            return _historicoCargoRepository.GetAll();
        }

        public void Create(HistoricoCargo historicoCargo)
        {
            _historicoCargoRepository.Add(historicoCargo);
        }

        public void Update(HistoricoCargo historicoCargo)
        {
            _historicoCargoRepository.Update(historicoCargo);
        }

        public void Delete(int id)
        {
            var historicoCargo = _historicoCargoRepository.GetById(id);
            if (historicoCargo != null)
            {
                _historicoCargoRepository.Remove(historicoCargo);
            }
        }

        // Implemente outros métodos específicos da interface IHistoricoCargoService, se necessário
    }
}