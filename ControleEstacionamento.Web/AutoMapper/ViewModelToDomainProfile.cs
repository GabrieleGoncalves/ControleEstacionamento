using AutoMapper;
using ControleEstacionamento.Domain.Entities;
using ControleEstacionamento.Web.ViewModels.MovimentacaoVeiculo;
using ControleEstacionamento.Web.ViewModels.Valores;

namespace ControleEstacionamento.Web.AutoMapper
{
    public class ViewModelToDomainProfile : Profile
    {
        public ViewModelToDomainProfile()
        {
            CreateMap<MovimentacaoVeiculoViewModelList, MovimentacaoVeiculo>();
            CreateMap<ValoresViewModelList, Valores>();

            CreateMap<ValoresViewModelList, Valores>();
            CreateMap<MovimentacaoVeiculoViewModelList, MovimentacaoVeiculo>();

            CreateMap<MovimentacaoVeiculoViewModelEntrada, MovimentacaoVeiculo>();
            
        }
    }
}