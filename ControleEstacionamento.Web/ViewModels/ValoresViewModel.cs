using System;
using ControleEstacionamento.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace ControleEstacionamento.Web.ViewModels
{
    public class ValoresViewModel
    {
        [Key]
        public int ValorId { get; set; }
        [Range(typeof(double), "0.0", "9999999.9" )]
        public double ValorHoraInicial { get; set; }
        public double TempoPermanencia { get; set; }
        public double ValorHoraAdicional { get; set; }
        public double ValorTotal { get; set; }

        //public virtual ICollection<VeiculoViewModel> ListaVeiculo { get; set; }
    }
}