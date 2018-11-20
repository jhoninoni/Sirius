using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Infra.Data.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Infra.Data.Repositories
{
    public class MensagemRepository :RepositoryBase<MensagemDomain>
    {
        private readonly ContextoSirius _contextoSirius;

        public MensagemRepository()
        {
            _contextoSirius = new ContextoSirius();
        }

        public List<MensagemDomain> ObterMensagemLista()
        {
            try
            {
                var query = @"SELECT id
                                   , user_from_id
                                   , user_to_id
                                   , group_id
                                   , client_id
                                   , message
                                   , created_at
                                   , updated_at
                                   , file
                                   , channel
                                   , timetoken
                                   , file_name
                                   , send
                                   , read
                                   , delivered
                              FROM public.messages;";

                return _contextoSirius.Database.SqlQuery<MensagemDomain>(query).ToList();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public MensagemDomain ObterMensagemId(int id)
        {
            try
            {
                var query = @"SELECT id
                                   , user_from_id
                                   , user_to_id
                                   , group_id
                                   , client_id
                                   , message
                                   , created_at
                                   , updated_at
                                   , file
                                   , channel
                                   , timetoken
                                   , file_name
                                   , send
                                   , read
                                   , delivered
                              FROM public.messages;";

                return _contextoSirius.Database.SqlQuery<MensagemDomain>(query).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void IncluirMensagem(MensagemDomain domain)
        {

        }

        public void AlterarMensagem(MensagemDomain domain)
        {

        }

        public void RemoverMensagemId(int id)
        {

        }
    }
}
