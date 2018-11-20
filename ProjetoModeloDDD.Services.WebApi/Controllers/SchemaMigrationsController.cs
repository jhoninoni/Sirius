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
    public class SchemaMigrationsController : ApiController
    {
        private SchemaMigrationsRepository _schemaMigrationsRepository = new SchemaMigrationsRepository();

        public List<SchemaMigrationsDomain> Get()
        {
            return _schemaMigrationsRepository.ObterSchemaMigrationsLista();
        }

        public SchemaMigrationsDomain Get(string version)
        {
            return _schemaMigrationsRepository.ObterSchemaMigrationsVersion(version);
        }

        public void Post([FromBody]string value)
        {
        }

        public void Put(int id, [FromBody]string value)
        {
        }
    }
}
