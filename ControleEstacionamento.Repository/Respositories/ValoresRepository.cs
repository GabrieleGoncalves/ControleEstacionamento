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
    }
}
