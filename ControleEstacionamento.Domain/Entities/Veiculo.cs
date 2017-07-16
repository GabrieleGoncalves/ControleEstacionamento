﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstacionamento.Domain.Entities
{
    public class Veiculo
    {
        public int VeiculoId { get; set; }
        public string Placa { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string NomeCliente { get; set; }
        public DateTime HoraEntrada { get; set; }
        public DateTime? HoraSaida { get; set; }

        public virtual ICollection<Valores> ListaValores { get; set; }

        public Veiculo()
        {
            ListaValores = new List<Valores>();
            this.HoraEntrada = DateTime.Now; //pode isso aqui?
        }

             

    }
}
