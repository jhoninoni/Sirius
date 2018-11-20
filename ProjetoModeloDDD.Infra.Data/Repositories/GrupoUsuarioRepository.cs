using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Infra.Data.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Infra.Data.Repositories
{
    public class GrupoUsuarioRepository : RepositoryBase<GrupoUsuarioDomain>
    {
        private readonly ContextoSirius _contextoSirius;

        public GrupoUsuarioRepository()
        {
            _contextoSirius = new ContextoSirius();
        }

        public List<GrupoUsuarioDomain> ObterGrupoUsuarioDomainLista()
        {
            try
            {
                var query = @"SELECT id
                                   , group_id
                                   , user_id
                                   , entry_date
                                   , exit_date
                                   , active
                                   , created_at
                                   , updated_at
	                         FROM public.groups_users;";

                return _contextoSirius.Database.SqlQuery<GrupoUsuarioDomain>(query).ToList();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        
        public GrupoUsuarioDomain ObterGrupoUsuarioDomainId(int id)
        {
            try
            {
                var query = @"SELECT id
                                   , group_id
                                   , user_id
                                   , entry_date
                                   , exit_date
                                   , active
                                   , created_at
                                   , updated_at
	                         FROM public.groups_users WHERE id = " + id + ";";

                return _contextoSirius.Database.SqlQuery<GrupoUsuarioDomain>(query).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void IncluirGrupoUsuarioDomain(GrupoUsuarioDomain domain)
        {

        }

        public void AlterarGrupoUsuarioDomain(GrupoUsuarioDomain domain)
        {

        }

        public void RemoverGrupoUsuarioDomain(int id)
        {

        }
    }
}
