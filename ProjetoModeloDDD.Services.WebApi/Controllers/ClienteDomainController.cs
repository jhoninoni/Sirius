using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProjetoModeloDDD.Services.WebApi.Controllers
{
    public class ClienteDomainController : ApiController
    {
        private ClienteDominioRepository _clienteDominioRepository = new ClienteDominioRepository();

        public List<ClienteDominioDomain> Get()
        {
            return _clienteDominioRepository.ObterClienteDomainLista();
        }

        public ClienteDominioDomain Get(int id)
        {
            return _clienteDominioRepository.ObterClienteDomainId(id);
        }

        public void Post([FromBody]string value)
        {
        }

        public void Put(int id, [FromBody]string value)
        {
        }
    }
}
