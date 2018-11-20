using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Infra.Data.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Infra.Data.Repositories
{
    public class ClienteRepository : RepositoryBase<ClienteDomain>
    {
        private readonly ContextoSirius _contextoSirius;

        public ClienteRepository()
        {
            _contextoSirius = new ContextoSirius();
        }

        public List<ClienteDomain> ObterClienteLista()
        {
            try
            {
                var query = @"SELECT id
                                   , name
                                   , created_at
                                   , updated_at
	                          FROM public.clients;";

                return _contextoSirius.Database.SqlQuery<ClienteDomain>(query).ToList();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public ClienteDomain ObterClienteId(int id)
        {
            try
            {
                var query = @"SELECT id
                                   , name
                                   , created_at
                                   , updated_at
	                          FROM public.clients WHERE id=" + id + ";";

                return _contextoSirius.Database.SqlQuery<ClienteDomain>(query).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void IncluirCliente(ClienteDomain domain)
        {

        }

        public void AlterarCliente(ClienteDomain domain)
        {

        }

        public void RemoverCliente(int id)
        {

        }
    }
}
