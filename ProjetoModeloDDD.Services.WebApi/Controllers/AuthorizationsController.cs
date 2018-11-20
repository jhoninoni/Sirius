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
    public class AuthorizationsController : ApiController
    {
        private AuthorizationsReposiroy _authorizationsReposiroy = new AuthorizationsReposiroy();

        public List<AuthorizationsDomain> Get()
        {
            return _authorizationsReposiroy.ObterAutorizationsLista();
        }

        public AuthorizationsDomain Get(int id)
        {
            return _authorizationsReposiroy.ObterAutorizationsId(id);
        }

        public void Post([FromBody]string value)
        {
        }

        public void Put(int id, [FromBody]string value)
        {
        }
    }
}
