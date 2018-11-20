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
    public class SolicitacaoAcessoAppService : AppServiceBase<SolicitacaoAcesso> , ISolicitacaoAcessoAppService
    {
        #region Variavel

        private readonly ISolicitacaoAcessoService _solicitacaoAcessoService;

        #endregion

        #region Contrutor

        public SolicitacaoAcessoAppService(ISolicitacaoAcessoService solicitacaoAcessoService)
            :base(solicitacaoAcessoService)
        {
            _solicitacaoAcessoService = solicitacaoAcessoService;
        }

        #endregion
    }
}
