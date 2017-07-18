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
            CreateMap<MovimentacaoVeiculo, MovimentacaoVeiculoViewModelList>();

            CreateMap<Valores, ValoresViewModelList>();

            CreateMap<Valores, ValoresViewModelList>();
        }
    }
}