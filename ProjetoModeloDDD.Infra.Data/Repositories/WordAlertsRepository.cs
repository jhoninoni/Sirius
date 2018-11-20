using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Infra.Data.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Infra.Data.Repositories
{
    public class WordAlertsRepository : RepositoryBase<WordAlertsDomain>
    {
        private readonly ContextoSirius _contextoSirius;

        public WordAlertsRepository()
        {
            _contextoSirius = new ContextoSirius();
        }

        public List<WordAlertsDomain> ObterWordAlertsLista()
        {
            try
            {
                var query = @"SELECT id, value, created_at, updated_at, client_id FROM public.word_alerts;";
                return _contextoSirius.Database.SqlQuery<WordAlertsDomain>(query).ToList();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public WordAlertsDomain ObterWordAlertsId(int id)
        {
            try
            {
                var query = @"SELECT id, value, created_at, updated_at, client_id FROM public.word_alerts WHERE id=" + id + ";";
                return _contextoSirius.Database.SqlQuery<WordAlertsDomain>(query).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void IncluirWordAlerts(WordAlertsDomain domain)
        {

        }

        public void AlterarWordAlerts(WordAlertsDomain domain)
        {

        }

        public void RemoverWordAlertsId(int id)
        {

        }
    }
}
