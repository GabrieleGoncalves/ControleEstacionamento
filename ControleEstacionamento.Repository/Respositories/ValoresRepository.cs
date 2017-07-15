using ControleEstacionamento.Repository.Base;
using ControleEstacionamento.Domain.Entities;
using ControleEstacionamento.Repository.Respositories.Interfaces;
using ControleEstacionamento.Persistence.Entity.Context;
using System;
using System.Collections.Generic;

namespace ControleEstacionamento.Repository.Respositories
{
    public class ValoresRepository : CrudRepository<Valores, int>, IValoresRepository
    {
        public ValoresRepository (EstacionamentoDbContext context)
            : base(context) { }

        public override List<Valores> Select(Func<Valores, bool> where = null)
        {
            //ICollection<Veiculo> resultado = _context.Set<Veiculo>()
            //                                  .Include(p => p.placa)
            //                                  .AsNoTracking();

            //    if (where != null)
            //        resultado = resultado.Where(where);
            //    return resultado.ToList();

        }

        public override bool Insert(Valores entity)
        {
            return base.Insert(entity);
        }
    }
}
