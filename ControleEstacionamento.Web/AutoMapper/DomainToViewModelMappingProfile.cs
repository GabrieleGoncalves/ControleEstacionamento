using AutoMapper;
using ControleEstacionamento.Web.ViewModels;
using ControleEstacionamento.Domain.Entities;



namespace ControleEstacionamento.Web.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<ValoresViewModel, Valores>();
            CreateMap<VeiculoViewModel, Veiculo>();

        }
    }
}