using ControleEstacionamento.Repository.Base;
using ControleEstacionamento.Domain.Entities;
using ControleEstacionamento.Repository.Respositories.Interfaces;
using ControleEstacionamento.Persistence.Entity.Context;
using System.Data.Entity;
using System.Linq;
using System.Collections.Generic;
using System;

namespace ControleEstacionamento.Repository.Respositories
{
    public class MovimentacaoVeiculoRepository : CrudRepository<MovimentacaoVeiculo, int>, IMovimentacaoVeiculoRepository
    {
        public MovimentacaoVeiculoRepository(EstacionamentoDbContext context)
            : base(context)  { }

        public override List<MovimentacaoVeiculo> Select(Func<MovimentacaoVeiculo, bool> where = null)
        {
            IEnumerable<MovimentacaoVeiculo> resultado = _context.Set<MovimentacaoVeiculo>().Include(p => p.Valor);
                                                                          
            if (where != null)
                resultado = resultado.Where(where);
            return resultado.ToList();
        }

        public override MovimentacaoVeiculo SelectById(int id)
        {
            return _context.Set<MovimentacaoVeiculo>().Include(p => p.Valor)
                                                .Where(p => p.MovimentacaoVeiculoId == id).FirstOrDefault();

        }

    }
}
