using ControleEstacionamento.Repository.Base;
using ControleEstacionamento.Domain.Entities;
using ControleEstacionamento.Repository.Respositories.Interfaces;
using ControleEstacionamento.Persistence.Entity.Context;

namespace ControleEstacionamento.Repository.Respositories
{
    public class MovimentacaoVeiculoRepository : CrudRepository<MovimentacaoVeiculo, int>, IMovimentacaoVeiculoRepository
    {
        public MovimentacaoVeiculoRepository(EstacionamentoDbContext context)
            : base(context)
        { }

    }
}
