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
    public class MensagemController : ApiController
    {
        private MensagemRepository _mensagemRepository = new MensagemRepository();

        public List<MensagemDomain> Get()
        {
            return _mensagemRepository.ObterMensagemLista();
        }

        public MensagemDomain Get(int id)
        {
            return _mensagemRepository.ObterMensagemId(id);
        }

        public void Post([FromBody]string value)
        {
        }

        public void Put(int id, [FromBody]string value)
        {
        }
    }
}
