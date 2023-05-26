using NydusPL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NydusPL.Service
{
    public interface ICargoService
    {
        Cargo GetById(int id);
        IEnumerable<Cargo> GetAll();
        void Create(Cargo cargo);
        void Update(Cargo cargo);
        void Delete(int id);
        // Adicione outros métodos específicos, se necessário
    }
}
