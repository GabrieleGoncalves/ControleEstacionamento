using System.ComponentModel;
using System;

namespace ControleEstacionamento.Web.ViewModels.Valores
{
    public class ValoresViewModelList
    {
        public int ValorId { get; set; }

        [DisplayName("Inicio Vigencia")]
        public DateTime InicioVigencia { get; set; }

        [DisplayName("Fim de Vigencia")]
        public DateTime FimVigencia { get; set; }

        [DisplayName("Valor Hora")]
        public double ValorHora { get; set; }

        [DisplayName("Valor da hora adicional")]
        public double ValorHoraAdicional { get; set; }

        [DisplayName("Placa do Veiculo")]
        public string Placa { get; set; }

    }
}