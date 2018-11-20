using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Repositories;
using ProjetoModeloDDD.Infra.Data.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoModeloDDD.Infra.Data.Repositories
{
    public class UsuarioRepository : RepositoryBase<UsuarioDomain>, IUsuarioRepository
    {
        private readonly ContextoSirius _contextoSirius;

        public UsuarioRepository()
        {
            _contextoSirius = new ContextoSirius();
        }

        public List<UsuarioDomain> ObterUsuariosLista()
        {
            try
            {
                var query = @"SELECT id" +
                                  ", name" +
                                  ", username" +
                                  ", email" +
                                  ", password_digest" +
                                  ", photo" +
                                  ", description" +
                                  ", client_id" +
                                  ", supervisor_id" +
                                  ", phone_number" +
                                  ", created_at" +
                                  ", updated_at" +
                                  ", reset_token" +
                                  ", active" +
                                  ", confirm_token" +
                                  ", plan " +
                             "FROM public.users;";

                return _contextoSirius.Database.SqlQuery<UsuarioDomain>(query).ToList();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public UsuarioDomain ObterUsuariosId(int id)
        {
            try
            {
                var query = @"SELECT id" +
                                  ", name" +
                                  ", username" +
                                  ", email" +
                                  ", password_digest" +
                                  ", photo" +
                                  ", description" +
                                  ", client_id" +
                                  ", supervisor_id" +
                                  ", phone_number" +
                                  ", created_at" +
                                  ", updated_at" +
                                  ", reset_token" +
                                  ", active" +
                                  ", confirm_token" +
                                  ", plan " +
                             "FROM public.users WHERE id = " + id + ";";

                return _contextoSirius.Database.SqlQuery<UsuarioDomain>(query).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void IncluirUsuarios(UsuarioDomain domain)
        {
            try
            {
                var query = @"INSERT INTO public.users (name
                                                     , username
	                                                 , email
	                                                 , password_digest
	                                                 , description
	                                                 , client_id
	                                                 , phone_number
	                                                 , created_at
                                                     , UPDATED_AT
	                                                 , active
	                                                 , plan)
	                              VALUES('" + domain.Name + "','"
                                          + domain.Username + "','"
                                          + domain.Email + "','"
                                          + domain.Password_digest.ToString() + "','"
                                          + domain.Description + "',"
                                          + domain.Client_id + ",'"
                                          + domain.Phone_number + "','"
                                          + domain.Created_at.ToString("yyyy-MM-dd hh:mm:ss.fff tt") + "','"
                                          + domain.Updated_at.ToString("yyyy-MM-dd hh:mm:ss.fff tt") + "',"
                                          + domain.Active + ",'"
                                          + domain.Plan + "');";
                _contextoSirius.Database.ExecuteSqlCommand(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void TrocarSenha(string email)
        {
            try
            {
                var query = @"";
                _contextoSirius.Database.ExecuteSqlCommand(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AlterarUsuarios(int id, UsuarioDomain domain)
        {
            try
            {
                var query = @"UPDATE public.users
                             	SET name=?
                             	  , username=?
                             	  , email=?
                             	  , password_digest=?
                             	  , photo=?
                             	  , description=?
                             	  , client_id=?
                             	  , supervisor_id=?
                             	  , phone_number=?
                             	  , created_at=?
                             	  , updated_at=?
                             	  , reset_token=?
                             	  , active=?
                             	  , confirm_token=?
                             	  , plan=?
                             	WHERE <condition>;";
                _contextoSirius.Database.ExecuteSqlCommand(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void RemoverUsuariosId(int id)
        {
            try
            {
                var query = @"DELETE FROM public.users WHERE id=" + id +";";
                _contextoSirius.Database.ExecuteSqlCommand(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
