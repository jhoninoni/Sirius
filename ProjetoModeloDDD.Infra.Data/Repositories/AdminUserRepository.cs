using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Infra.Data.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Infra.Data.Repositories
{
    public class AdminUserRepository : RepositoryBase<AdminUserDomain>
    {
        private readonly ContextoSirius _contextoSirius;

        public AdminUserRepository()
        {
            _contextoSirius = new ContextoSirius();
        }

        public List<AdminUserDomain> ObterAdminUserLista()
        {
            try
            {
                var query = @"SELECT id
                                 , email
                                 , encrypted_password
                                 , reset_password_token
                                 , reset_password_sent_at
                                 , remember_created_at
                                 , sign_in_count
                                 , current_sign_in_at
                                 , last_sign_in_at
                                 , current_sign_in_ip
                                 , last_sign_in_ip
                                 , created_at
                                 , updated_at
                                 , client_id
                                 , phone
                            FROM public.admin_users;";

                return _contextoSirius.Database.SqlQuery<AdminUserDomain>(query).ToList();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public AdminUserDomain ObterAdminUserId(int id)
        {
            try
            {
                var query = @"SELECT id
                                 , email
                                 , encrypted_password
                                 , reset_password_token
                                 , reset_password_sent_at
                                 , remember_created_at
                                 , sign_in_count
                                 , current_sign_in_at
                                 , last_sign_in_at
                                 , current_sign_in_ip
                                 , last_sign_in_ip
                                 , created_at
                                 , updated_at
                                 , client_id
                                 , phone
                            FROM public.admin_users WHERE id =" + id + ";";

                return _contextoSirius.Database.SqlQuery<AdminUserDomain>(query).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void IncluirAdminUser(AdminUserDomain domain)
        {

        }

        public void AlterarAdminUser(AdminUserDomain domain)
        {

        }

        public void RemoverAdminUserId(int id)
        {

        }
    }
}
