using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstacionamento.Domain.Entities
{
    public class Valores
    {
        public int ValorId { get; set; }
        public double ValorHoraInicial { get; set; }
        public double TempoPermanencia { get; set; }
        public double ValorHoraAdicional { get; set; }
        public double ValorTotal { get; set; }

        public virtual IEnumerable<Veiculo> ListaVeiculo { get; set; }

        public Valores()
        {
            ListaVeiculo = new List<Veiculo>();
        }
    }
}
