using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstacionamento.Domain.Entities
{

    public class MovimentacaoVeiculo
    {
        public int MovimentacaoVeiculoId { get; set; }
        public string Placa { get; set; }
        public string NomeCliente { get; set; }
        public DateTime Entrada { get; set; }
        public DateTime? Saida { get; set; }
        public int? HorasPermanencia { get; set; }
        public int? MinutosPermanencia { get; set; }
        public double ValorTotal { get; set; }

        public virtual Valores Valor { get; set; }
        public int ValorId { get; set; }

        public MovimentacaoVeiculo()
        {

        }

    }
}
