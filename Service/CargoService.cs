using NydusPL.Models;
using NydusPL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NydusPL.Service
{
    public class CargoService : ICargoService
    {
        private readonly ICargoRepository _cargoRepository;

        public CargoService(ICargoRepository cargoRepository)
        {
            _cargoRepository = cargoRepository;
        }

        public Cargo GetById(int id)
        {
            return _cargoRepository.GetById(id);
        }

        public IEnumerable<Cargo> GetAll()
        {
            return _cargoRepository.GetAll();
        }

        public void Create(Cargo cargo)
        {
            _cargoRepository.Add(cargo);
        }

        public void Update(Cargo cargo)
        {
            _cargoRepository.Update(cargo);
        }

        public void Delete(int id)
        {
            var cargo = _cargoRepository.GetById(id);
            if (cargo != null)
            {
                _cargoRepository.Remove(cargo);
            }
        }

        // Implemente outros métodos específicos da interface ICargoService, se necessário
    }
}