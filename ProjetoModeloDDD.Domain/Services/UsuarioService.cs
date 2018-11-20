using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Repositories;
using ProjetoModeloDDD.Domain.Interfaces.Services;

namespace ProjetoModeloDDD.Domain.Services
{
    public class UsuarioService : ServiceBase<UsuarioDomain> , IUsuarioService
    {
        #region Variavel

        private readonly IUsuarioRepository _usuarioRepository;

        #endregion

        #region Contrutor

        public UsuarioService(IUsuarioRepository usuarioRepository)
            :base(usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        #endregion
    }
}
