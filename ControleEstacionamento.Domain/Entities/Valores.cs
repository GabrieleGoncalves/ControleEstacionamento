using System.Collections.Generic;

namespace ControleEstacionamento.Domain.Entities
{
    public class Valores
    {
        public int ValorId { get; set; }
        public double ValorHoraInicial { get; set; }
        public double TempoPermanencia { get; set; }
        public double ValorHoraAdicional { get; set; }
        public double ValorTotal { get; set; }

        public virtual ICollection<Veiculo> ListaVeiculo { get; set; }

        public Valores()
        {
            ListaVeiculo = new List<Veiculo>();
        }
    }
}
