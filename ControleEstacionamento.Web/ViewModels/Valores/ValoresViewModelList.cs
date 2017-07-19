using System.ComponentModel;
using System;

namespace ControleEstacionamento.Web.ViewModels.Valores
{
    public class ValoresViewModelList
    {
        public int ValorId { get; set; }

        [DisplayName("Inicio de Vigencia")]
        public DateTime InicioVigencia { get; set; }

        [DisplayName("Fim de Vigencia")]
        public DateTime FimVigencia { get; set; }

        [DisplayName("Valor da Hora")]
        public double ValorHora { get; set; }

        [DisplayName("Valor da Hora Adicional")]
        public double ValorAdicional { get; set; }
    }
}