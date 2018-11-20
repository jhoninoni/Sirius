using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Infra.Data.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Infra.Data.Repositories
{
    public class ActiveAdminCommentsRepository : RepositoryBase<ActiveAdminCommentsDomain>
    {
        private readonly ContextoSirius _contextoSirius;

        public ActiveAdminCommentsRepository()
        {
            _contextoSirius = new ContextoSirius();
        }

        public List<ActiveAdminCommentsDomain> ObterActiveAdminComentsLista()
        {
            try
            {
                var query = @"SELECT id
                                   , namespace
                                   , body
                                   , resource_id
                                   , resource_type
                                   , author_id
                                   , author_type
                                   , created_at
                                   , updated_at
	                          FROM public.active_admin_comments;";

                return _contextoSirius.Database.SqlQuery<ActiveAdminCommentsDomain>(query).ToList();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public ActiveAdminCommentsDomain ObterActiveAdminComentsId(int id)
        {
            try
            {
                var query = @"SELECT id
                                   , namespace
                                   , body
                                   , resource_id
                                   , resource_type
                                   , author_id
                                   , author_type
                                   , created_at
                                   , updated_at
	                          FROM public.active_admin_comments WHERE id = "+ id +";";

                return _contextoSirius.Database.SqlQuery<ActiveAdminCommentsDomain>(query).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void IncluirActiveAdminComents(ActiveAdminCommentsDomain domain)
        {
            
        }

        public void AlterarActiveAdminComents(ActiveAdminCommentsDomain domain)
        {

        }

        public void RemoverActiveAdminComentsId(int id)
        {

        }
    }
}
