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
    public class GrupoUsuarioController : ApiController
    {
        private GrupoUsuarioRepository _grupoUsuarioRepository = new GrupoUsuarioRepository();

        public List<GrupoUsuarioDomain> Get()
        {
            return _grupoUsuarioRepository.ObterGrupoUsuarioDomainLista();
        }

        public GrupoUsuarioDomain Get(int id)
        {
            return _grupoUsuarioRepository.ObterGrupoUsuarioDomainId(id);
        }

        public void Post([FromBody]string value)
        {
        }

        public void Put(int id, [FromBody]string value)
        {
        }
    }
}
