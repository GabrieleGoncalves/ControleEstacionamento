using ControleEstacionamento.Web.ViewModels.Valores;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ControleEstacionamento.Web.ViewModels.MovimentacaoVeiculo
{
    public class MovimentacaoVeiculoViewModelList
    {
        public int MovimentacaoVeiculoId { get; set; }

        [DisplayName("Placa do Carro")]
        public string Placa { get; set; }

        [DisplayName("Nome cliente")]
        public string NomeCliente { get; set; }

        [DisplayName("Entrada")]
        public DateTime Entrada { get; set; }

        [DisplayName("Saída")]
        public DateTime? Saida { get; set; }

        [DisplayName("Valor total")]
        public double? ValorTotal { get; set; }

        [DisplayName("Valor")]
        public int ValorId { get; set; }

        public ValoresViewModelList Valor { get; set; }

    }
}
