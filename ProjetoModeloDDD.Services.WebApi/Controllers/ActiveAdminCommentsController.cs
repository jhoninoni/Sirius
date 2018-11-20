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
    public class ActiveAdminCommentsController : ApiController
    {
        private ActiveAdminCommentsRepository _activeAdminCommentsRepository = new ActiveAdminCommentsRepository();

        public List<ActiveAdminCommentsDomain> Get()
        {
            return _activeAdminCommentsRepository.ObterActiveAdminComentsLista();
        }

        public ActiveAdminCommentsDomain Get(int id)
        {
            return _activeAdminCommentsRepository.ObterActiveAdminComentsId(id);
        }

        public void Post([FromBody]string value)
        {
        }

        public void Put(int id, [FromBody]string value)
        {
        }
    }
}
