using ProjetoModeloDDD.Application.Interface;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Application
{
    public class UsuarioAppService : AppServiceBase<UsuarioDomain> , IUsuarioAppService
    {
        #region Variavel

        private readonly IUsuarioService _usuarioService;

        #endregion

        #region Construtor

        public UsuarioAppService(IUsuarioService usuarioService)
            :base(usuarioService)
        {
            _usuarioService = usuarioService;
        }

        #endregion
    }
}
