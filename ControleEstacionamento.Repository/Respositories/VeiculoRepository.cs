using ControleEstacionamento.Repository.Base;
using ControleEstacionamento.Domain.Entities;
using ControleEstacionamento.Repository.Respositories.Interfaces;
using ControleEstacionamento.Persistence.Entity.Context;

namespace ControleEstacionamento.Repository.Respositories
{
    public class VeiculoRepository : CrudRepository<Veiculo, int>, IVeiculoRepository
    {
        public VeiculoRepository (EstacionamentoDbContext context)
            : base(context)
        { }

        //public override List<Veiculo> Select(Func<Veiculo, bool> where = null)
        //{
        //    IEnumerable<TEntity> resultado = _context.Set<TEntity>();
        //    if (where != null)
        //        resultado = resultado.Where(where);
        //    return resultado.ToList();
        //}

        public override bool Insert(Veiculo entity)
        {
            return base.Insert(entity);
        }
    
    }
}
