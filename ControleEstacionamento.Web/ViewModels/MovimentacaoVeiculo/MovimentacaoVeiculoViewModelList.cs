using System;
using System.ComponentModel;

namespace ControleEstacionamento.ViewModels.Veiculo
{
    public class MovimentacaoVeiculoViewModelList
    {
        public int MovimentacaoVeiculoId { get; set; }

        [DisplayName("Placa do Carro")]
        public string Placa { get; set; }

        public string NomeCliente { get; set; }
        public DateTime Entrada { get; set; }
        public DateTime Saida { get; set; }
    }
}
