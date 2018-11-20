using AutoMapper;
using JBS.CSC.Potal.Models;
using ProjetoModeloDDD.Domain.Entities;

namespace JBS.CSC.Potal.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<Usuario, UsuarioModel>();
            Mapper.CreateMap<Sistema, SistemaModel>();
            Mapper.CreateMap<SolicitacaoAcesso, SolicitacaoAcessoModel>();
        }
    }
}