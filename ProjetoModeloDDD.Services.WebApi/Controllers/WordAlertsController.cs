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
    public class WordAlertsController : ApiController
    {
        private WordAlertsRepository _wordAlertsRepository = new WordAlertsRepository();

        public List<WordAlertsDomain> Get()
        {
            return _wordAlertsRepository.ObterWordAlertsLista();
        }

        public WordAlertsDomain Get(int id)
        {
            return _wordAlertsRepository.ObterWordAlertsId(id);
        }

        public void Post([FromBody]string value)
        {
        }

        public void Put(int id, [FromBody]string value)
        {
        }
    }
}
