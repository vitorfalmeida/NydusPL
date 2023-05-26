using NydusPL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NydusPL.Repository
{
    
        public interface ICargoRepository : IRepository<Cargo>
        {
            IEnumerable<Cargo> GetByNome(string nome);
            IEnumerable<Cargo> GetByCBO(string cbo);
            // Adicione outros métodos específicos do repositório de cargos, se necessário
        }
 }

