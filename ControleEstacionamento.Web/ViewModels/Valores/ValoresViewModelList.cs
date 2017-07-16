using System.ComponentModel;

namespace ControleEstacionamento.Web.ViewModels.Valores
{
    public class ValoresViewModelList
    {
        public int ValorId { get; set; }

        [DisplayName("Valor da hora inicial")]
        public double ValorHoraInicial { get; set; }

        [DisplayName("Valor de tempo de permanência")]
        public double TempoPermanencia { get; set; }

        [DisplayName("Valor da hora adicional")]
        public double ValorHoraAdicional { get; set; }

        [DisplayName("Valor total")]
        public double ValorTotal { get; set; }
    }
}