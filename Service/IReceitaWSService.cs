using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NydusPL.Service
{
    public interface IReceitaWSService
    {
        Task<bool> IsValidCnpj(string cnpj);
        Task<bool> ValidarCNPJ(string cnpj);
        
    }
}
