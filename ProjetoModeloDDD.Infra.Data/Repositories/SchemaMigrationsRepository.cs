using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Infra.Data.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Infra.Data.Repositories
{
    public class SchemaMigrationsRepository : RepositoryBase<SchemaMigrationsDomain>
    {
        private readonly ContextoSirius _contextoSirius;

        public SchemaMigrationsRepository()
        {
            _contextoSirius = new ContextoSirius();
        }

        public List<SchemaMigrationsDomain> ObterSchemaMigrationsLista()
        {
            try
            {
                var query = @"SELECT version FROM public.schema_migrations;";
                return _contextoSirius.Database.SqlQuery<SchemaMigrationsDomain>(query).ToList();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public SchemaMigrationsDomain ObterSchemaMigrationsVersion(string version)
        {
            try
            {
                var query = @"SELECT version FROM public.schema_migrations WHERE versim like '%" + version + "%';";
                return _contextoSirius.Database.SqlQuery<SchemaMigrationsDomain>(query).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void IncluirSchemaMigrations(SchemaMigrationsDomain domain)
        {

        }

        public void AlterarSchemaMigrations(SchemaMigrationsDomain domain)
        {

        }

        public void RemoverSchemaMigrationsId(int id)
        {

        }
    }
}
