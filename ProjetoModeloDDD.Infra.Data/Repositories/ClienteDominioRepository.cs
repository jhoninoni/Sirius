using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Infra.Data.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Infra.Data.Repositories
{
    public class ClienteDominioRepository : RepositoryBase<ClienteDominioDomain>
    {
        private readonly ContextoSirius _contextoSirius;

        public ClienteDominioRepository()
        {
            _contextoSirius = new ContextoSirius();
        }

        public List<ClienteDominioDomain> ObterClienteDomainLista()
        {
            try
            {
                var query = @"SELECT id
                                   , client_id
                                   , dns
                                   , created_at
                                   , updated_at
                              FROM public.client_domains;";

                return _contextoSirius.Database.SqlQuery<ClienteDominioDomain>(query).ToList();
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public ClienteDominioDomain ObterClienteDomainId(int id)
        {
            try
            {
                var query = @"SELECT id
                                   , client_id
                                   , dns
                                   , created_at
                                   , updated_at
                              FROM public.client_domains WHERE id= " + id + ";";

                return _contextoSirius.Database.SqlQuery<ClienteDominioDomain>(query).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public ClienteDominioDomain ObterClienteDominio(string dominio)
        {
            try
            {
                var query = @"SELECT id, client_id, dns, created_at, updated_at
                              FROM public.client_domains
                              WHERE UPPER(DNS) LIKE UPPER('" + dominio + "%');";

                return _contextoSirius.Database.SqlQuery<ClienteDominioDomain>(query).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void IncluirClienteDomain(ClienteDominioDomain domain)
        {

        }

        public void AlterarClienteDomain(ClienteDominioDomain domain)
        {

        }

        public void RemoverClienteDomainId(int id)
        {

        }
    }
}
