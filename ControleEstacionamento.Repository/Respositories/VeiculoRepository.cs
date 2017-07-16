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

    }
}
