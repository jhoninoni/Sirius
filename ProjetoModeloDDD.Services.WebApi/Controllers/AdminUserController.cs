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
    public class AdminUserController : ApiController
    {
        private AdminUserRepository _adminUser = new AdminUserRepository();

        public List<AdminUserDomain> Get()
        {
            return _adminUser.ObterAdminUserLista();
        }

        public AdminUserDomain Get(int id)
        {
            return _adminUser.ObterAdminUserId(id);
        }

        public void Post([FromBody]string value)
        {
        }

        public void Put(int id, [FromBody]string value)
        {
        }
    }
}
