using AutoMapper;
using ControleEstacionamento.Domain.Entities;
using ControleEstacionamento.ViewModels.Veiculo;
using ControleEstacionamento.Web.ViewModels.Valores;

namespace ControleEstacionamento.Web.AutoMapper
{
    public class ViewModelToDomainProfile : Profile
    {
        public ViewModelToDomainProfile()
        {
            CreateMap<VeiculoViewModelList, Veiculo>();


            CreateMap<ValoresViewModelList, Valores>();
        }
    }
}