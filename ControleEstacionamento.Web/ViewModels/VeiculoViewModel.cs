using System;
using ControleEstacionamento.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace ControleEstacionamento.Web.ViewModels
{
    public class VeiculoViewModel
    {
        [Key]
        public int VeiculoId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Placa")]
        [MaxLength(7, ErrorMessage ="Máximo {0} caracteres")]
        public string Placa { get; set; }

        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string NomeCliente { get; set; }
        public DateTime HoraEntrada { get; set; }
        public DateTime? HoraSaida { get; set; }

        public int ValorId { get; set; }
        public virtual ValoresViewModel Valores { get; set; }
        
    }
}