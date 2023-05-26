using NydusPL.Models;
using NydusPL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace NydusPL.Service
{
    public class EmpresaService : IEmpresaService
    {
        private readonly IEmpresaRepository _empresaRepository;
        private readonly IReceitaWSService _receitaWSService;

        public EmpresaService(IEmpresaRepository empresaRepository, IReceitaWSService receitaWSService)
        {
            _empresaRepository = empresaRepository;
            _receitaWSService = receitaWSService;
        }       

        public Empresa GetById(int id)
        {
            return _empresaRepository.GetById(id);
        }

        public IEnumerable<Empresa> GetAll()
        {
            return _empresaRepository.GetAll();
        }

        public async Task Create(Empresa empresa)
        {
            if (await _receitaWSService.IsValidCnpj(empresa.Cnpj))
            {
                _empresaRepository.Add(empresa);
            }
            else
            {
                throw new Exception("CNPJ inválido ou empresa não encontrada na ReceitaWS.");
            }
        }


        public async Task Update(Empresa empresa)
        {
            if (await _receitaWSService.IsValidCnpj(empresa.Cnpj))
            {
                _empresaRepository.Update(empresa);
            }
            else
            {
                throw new Exception("CNPJ inválido ou empresa não encontrada na ReceitaWS.");
            }
        }

        public void Delete(int id)
        {
            var empresa = _empresaRepository.GetById(id);
            if (empresa != null)
            {
                _empresaRepository.Remove(empresa);
            }
        }

        public Empresa GetByCnpj(string cnpj)
        {
            return _empresaRepository.GetByCnpj(cnpj);
        }

        // Implemente outros métodos específicos da interface IEmpresaService, se necessário
    }

}