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

        public string NomeCliente { get; set; }

        public DateTime Entrada { get; set; }

        public DateTime? Saida { get; set; }
        public DateTime TempoPermanencia { get; set; }
        public DateTime HoraAdicional { get; set; }
        public double ValorTotal { get; set; }

        [DisplayName("Valor")]
        [Required(ErrorMessage ="Escolha um valor")]
        public int ValorId { get; set; }
    }
}
