using NydusPL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NydusPL.Repository
{
    public interface IEmpresaRepository : IRepository<Empresa>
    {
        Empresa GetByCnpj(string cnpj);

    }

}
