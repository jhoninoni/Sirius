

using System.Collections.Generic;
using System.Linq;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Repositories;
using ProjetoModeloDDD.Domain.Interfaces.Services;

namespace ProjetoModeloDDD.Domain.Services
{
    public class ClienteService : ServiceBase<ClienteDominioDomain>
    {
        //private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
            : base(clienteRepository)
        {
            //_clienteRepository = clienteRepository;
        }

        //public IEnumerable<ClienteDominioDomain> ObterClientesEspeciais(IEnumerable<ClienteDominioDomain> clientes)
        //{
        //    return clientes.Where(c => c.ClienteEspecial(c));
        //}
    }
}
