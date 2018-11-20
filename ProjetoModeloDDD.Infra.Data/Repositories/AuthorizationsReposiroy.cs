using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Infra.Data.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Infra.Data.Repositories
{
    public class AuthorizationsReposiroy : RepositoryBase<AuthorizationsDomain>
    {
        private readonly ContextoSirius _contextoSirius;

        public AuthorizationsReposiroy()
        {
            _contextoSirius = new ContextoSirius();
        }

        public List<AuthorizationsDomain> ObterAutorizationsLista()
        {
            try
            {
                var query = @"SELECT id
                                   , user_id
                                   , identifier
                                   , token
                                   , created_at
                                   , updated_at
	                          FROM public.authorizations;";

                return _contextoSirius.Database.SqlQuery<AuthorizationsDomain>(query).ToList();

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public AuthorizationsDomain ObterAutorizationsId(int id)
        {
            try
            {
                var query = @"SELECT id
                                   , user_id
                                   , identifier
                                   , token
                                   , created_at
                                   , updated_at
	                          FROM public.authorizations WHERE id = " + id + ";";

                return _contextoSirius.Database.SqlQuery<AuthorizationsDomain>(query).SingleOrDefault();

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void IncluirAuthorizations(AuthorizationsDomain domain)
        {

        }

        public void AlterarAuthorizations(AuthorizationsDomain domain)
        {

        }

        public void RemoverAuthorizationsId(int id)
        {

        }
    }
}
