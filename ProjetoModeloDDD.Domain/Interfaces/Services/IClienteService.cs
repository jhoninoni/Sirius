
using System.Collections.Generic;
using ProjetoModeloDDD.Domain.Entities;

namespace ProjetoModeloDDD.Domain.Interfaces.Services
{
    public interface IClienteService : IServiceBase<ClienteDominioDomain>
    {
        IEnumerable<ClienteDominioDomain> ObterClientesEspeciais(IEnumerable<ClienteDominioDomain> clientes);
    }
}
