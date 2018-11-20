using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Infra.Data.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Infra.Data.Repositories
{
    public class GroupsRepository : RepositoryBase<GroupsDomain>
    {
        private readonly ContextoSirius _contextoSirius;

        public GroupsRepository()
        {
            _contextoSirius = new ContextoSirius();
        }

        public List<GroupsDomain> ObterGroupsLista()
        {
            try
            {
                var query = @"SELECT id
                                   , name
                                   , photo
                                   , client_id
                                   , created_at
                                   , updated_at
	                          FROM public.groups;";

                return _contextoSirius.Database.SqlQuery<GroupsDomain>(query).ToList();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public GroupsDomain ObterGroupsId(int id)
        {
            try
            {
                var query = @"SELECT id
                                   , name
                                   , photo
                                   , client_id
                                   , created_at
                                   , updated_at
	                          FROM public.groups WHERE id =" + id + ";";

                return _contextoSirius.Database.SqlQuery<GroupsDomain>(query).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw;
            }
        }


        public void IncluirGroups(GroupsDomain domain)
        {

        }

        public void AlterarGroups(GroupsDomain domain)
        {

        }

        public void RemoverGroupsId(int id)
        {

        }

    }
}
