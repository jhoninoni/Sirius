
using System.Collections.Generic;
using ProjetoModeloDDD.Domain.Entities;

namespace ProjetoModeloDDD.Application.Interface
{
    public interface IClienteAppService : IAppServiceBase<ClienteDominioDomain>
    {
        IEnumerable<ClienteDominioDomain> ObterClientesEspeciais();
    }
}
