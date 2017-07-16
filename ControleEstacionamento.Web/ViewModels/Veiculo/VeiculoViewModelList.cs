using System;
using System.ComponentModel;

namespace ControleEstacionamento.ViewModels.Veiculo
{
    public class VeiculoViewModelList
    {
        public int VeiculoId { get; set; }

        public string Placa { get; set; }

        public string Marca { get; set; }

        public string Modelo { get; set; }

        public string NomeCliente { get; set; }

        public DateTime HoraEntrada { get; set; }

        public DateTime? HoraSaida { get; set; }

        [DisplayName("Valor")]
        public int ValorId { get; set; }

        public VeiculoViewModelList()
        {
            this.HoraEntrada = DateTime.Now;
        }
    }
}