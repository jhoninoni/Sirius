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
    public class GroupsController : ApiController
    {
        private GroupsRepository _groupsRepository = new GroupsRepository();

        public List<GroupsDomain> ObterGroupsLista()
        {
            return _groupsRepository.ObterGroupsLista();
        }

        public GroupsDomain ObterGroupsId(int id)
        {
            return _groupsRepository.ObterGroupsId(id);
        }

        public void Post([FromBody]string value)
        {
        }

        public void Put(int id, [FromBody]string value)
        {
        }
    }
}
