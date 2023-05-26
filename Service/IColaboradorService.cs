using NydusPL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NydusPL.Service
{
    public interface IColaboradorService
    {
        Colaborador GetById(int id);
        IEnumerable<Colaborador> GetAll();
        void Create(Colaborador colaborador);
        void Update(Colaborador colaborador);
        void Delete(int id);
        // Adicione outros métodos específicos, se necessário
    }
}
