using NydusPL.Models;
using NydusPL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NydusPL.Service
{
    public class ColaboradorService : IColaboradorService
    {
        private readonly IColaboradorRepository _colaboradorRepository;

        public ColaboradorService(IColaboradorRepository colaboradorRepository)
        {
            _colaboradorRepository = colaboradorRepository;
        }

        public Colaborador GetById(int id)
        {
            return _colaboradorRepository.GetById(id);
        }

        public IEnumerable<Colaborador> GetAll()
        {
            return _colaboradorRepository.GetAll();
        }

        public void Create(Colaborador colaborador)
        {
            _colaboradorRepository.Add(colaborador);
        }

        public void Update(Colaborador colaborador)
        {
            _colaboradorRepository.Update(colaborador);
        }

        public void Delete(int id)
        {
            var colaborador = _colaboradorRepository.GetById(id);
            if (colaborador != null)
            {
                _colaboradorRepository.Remove(colaborador);
            }
        }

        // Implemente outros métodos específicos da interface IColaboradorService, se necessário
    }
}