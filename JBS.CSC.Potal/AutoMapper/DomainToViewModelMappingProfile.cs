using AutoMapper;
using JBS.CSC.Potal.Models;
using ProjetoModeloDDD.Domain.Entities;

namespace JBS.CSC.Potal.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<UsuarioModel, Usuario>();
            Mapper.CreateMap<SistemaModel, Sistema>();
            Mapper.CreateMap<SolicitacaoAcessoModel, SolicitacaoAcesso>();
        }
    }
}