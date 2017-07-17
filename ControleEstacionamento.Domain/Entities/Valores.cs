using System;
using System.Collections.Generic;

namespace ControleEstacionamento.Domain.Entities
{
    public class Valores
    {
        public int ValorId { get; set; }
        public DateTime InicioVigencia { get; set; }
        public DateTime FimVigencia { get; set; }
        public double ValorHora { get; set; }
        public double ValorAdicional { get; set; }

        public virtual ICollection<MovimentacaoVeiculo> ListaMovimentacao { get; set; }


        public Valores()
        {
            ListaMovimentacao = new List<MovimentacaoVeiculo>();
        }
    }
}
