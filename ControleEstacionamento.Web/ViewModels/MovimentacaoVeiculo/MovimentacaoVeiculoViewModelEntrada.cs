using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ControleEstacionamento.Web.ViewModels.MovimentacaoVeiculo
{
    public class MovimentacaoVeiculoViewModelEntrada
    {
        
        [DisplayName("Placa do Carro")]
        public string Placa { get; set; }

        public string NomeCliente { get; set; }
        
     
    }
}