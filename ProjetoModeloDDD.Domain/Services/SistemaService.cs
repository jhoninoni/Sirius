using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Repositories;
using ProjetoModeloDDD.Domain.Interfaces.Services;

namespace ProjetoModeloDDD.Domain.Services
{
    public class SistemaService : ServiceBase<Sistema> , ISistemaService
    {
        #region Variavel

        private readonly ISistemaRepository _sistemaRepository;

        #endregion

        #region Contrutor

        public SistemaService(ISistemaRepository sistemaRepository)
            :base(sistemaRepository)
        {
            _sistemaRepository = sistemaRepository;
        }

        #endregion
    }
}
