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
    public class ClienteController : ApiController
    {
        private ClienteRepository _clienteRepository = new ClienteRepository();

        public List<ClienteDomain> Get()
        {
            return _clienteRepository.ObterClienteLista();
        }

        public ClienteDomain Get(int id)
        {
            return _clienteRepository.ObterClienteId(id);
        }

        public void Post([FromBody]string value)
        {
        }

        public void Put(int id, [FromBody]string value)
        {
        }
    }
}
