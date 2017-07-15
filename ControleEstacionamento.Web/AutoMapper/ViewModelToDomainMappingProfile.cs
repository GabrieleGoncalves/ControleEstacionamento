using ControleEstacionamento.Web.AutoMapper;
using ControleEstacionamento.Domain.Entities;
using ControleEstacionamento.Web.ViewModels;
using AutoMapper;



namespace ControleEstacionamento.Web.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<Valores, ValoresViewModel>();
            CreateMap<Veiculo, VeiculoViewModel>();
        }
    }
}
