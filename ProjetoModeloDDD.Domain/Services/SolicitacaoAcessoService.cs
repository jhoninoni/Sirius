using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Repositories;
using ProjetoModeloDDD.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Domain.Services
{
    public class SolicitacaoAcessoService : ServiceBase<SolicitacaoAcesso> , ISolicitacaoAcessoService
    {
        #region Variavel

        private readonly ISolicitacaoAcessoRepository _solicitacaoAcessoRepository;

        #endregion

        #region Construtor

        public SolicitacaoAcessoService(ISolicitacaoAcessoRepository solicitacaoAcessoRepository)
            :base(solicitacaoAcessoRepository)
        {
            _solicitacaoAcessoRepository = solicitacaoAcessoRepository;
        }

        #endregion
    }
}
