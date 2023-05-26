using NydusPL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NydusPL.Service
{
    public interface IEmpresaService
    {
        Empresa GetById(int id);
        IEnumerable<Empresa> GetAll();
        Task Create(Empresa empresa);
        Task Update(Empresa empresa);
        void Delete(int id);
        Empresa GetByCnpj(string cnpj);
        
        // Adicione outros métodos específicos, se necessário
    }

}
