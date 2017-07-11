using System.Data.Entity.ModelConfiguration;

namespace ControleEstacionamento.Persistence.Entity.TemplateConfiguration
{
    public abstract class PersistenceTypeConfiguration<TEntity> : EntityTypeConfiguration<TEntity> where TEntity : class
    {
        public PersistenceTypeConfiguration()
        {
            ConfiguraNomeTabela();
            ConfiguraCampos();
            ConfiguraChavePrimaria();
            ConfiguraRelacionamentos();
        }
        public abstract void ConfiguraNomeTabela();
        public abstract void ConfiguraCampos();
        public abstract void ConfiguraChavePrimaria();
        public abstract void ConfiguraRelacionamentos();
    }
}
