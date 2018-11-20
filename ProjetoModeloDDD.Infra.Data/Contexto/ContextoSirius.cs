using ProjetoModeloDDD.Infra.Data.EntityConfig;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Infra.Data.Contexto
{
    public class ContextoSirius : DbContext
    {
        public ContextoSirius() : base("PgSirius")
        {
        }

        //public DbSet<UsuarioConfiguration> Usuarios { get; set; }
    }
}
