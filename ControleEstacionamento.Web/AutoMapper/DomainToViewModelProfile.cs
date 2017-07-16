using AutoMapper;
using ControleEstacionamento.Domain.Entities;
using ControleEstacionamento.ViewModels.Veiculo;
using ControleEstacionamento.Web.ViewModels.Valores;

namespace ControleEstacionamento.Web.AutoMapper
{
    public class DomainToViewModelProfile : Profile
    {
        public DomainToViewModelProfile()
        {
            CreateMap<Veiculo, VeiculoViewModelList>();

            CreateMap<Valores, ValoresViewModelList>();

        }
    }
}