using ProjetoModeloDDD.Application.Interface;
using ProjetoModeloDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoModeloDDD.Domain.Interfaces.Services;

namespace ProjetoModeloDDD.Application
{
    public class SistemaAppService : AppServiceBase<Sistema>, ISistemaAppService
    {
        #region Variaveis

        private readonly ISistemaService _sistemaService;

        #endregion

        #region Construtor

        public SistemaAppService(ISistemaService sistemaService)
            :base(sistemaService)
        {
            _sistemaService = sistemaService;
        }

        #endregion
    }
}
