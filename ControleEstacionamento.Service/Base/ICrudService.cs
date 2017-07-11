using System;
using System.Collections.Generic;

namespace ControleEstacionamento.Service.Base
{
    public interface ICrudService<TEntity, Tkey>
       where TEntity : class
    {
        List<TEntity> Select(Func<TEntity, bool> where = null);

        TEntity SelectById(Tkey id);

        bool Insert(TEntity entity);
        bool Update(TEntity entity);
        bool Delete(TEntity entity);
        bool DeleteById(Tkey id);
    }
}
