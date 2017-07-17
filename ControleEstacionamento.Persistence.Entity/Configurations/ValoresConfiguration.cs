using ControleEstacionamento.Domain.Entities;
using ControleEstacionamento.Persistence.Entity.TemplateConfiguration;

namespace ControleEstacionamento.Persistence.Entity.Configurations
{
    public class ValoresConfiguration: PersistenceTypeConfiguration<Valores>
    {
        public override void ConfiguraCampos()
        {
            Property(p => p.ValorId)
                .IsRequired()
                .HasColumnName("val_codigo");

            Property(p => p.InicioVigencia)
                .HasColumnName("val_inicio_vigencia");

            Property(p => p.FimVigencia)
                .HasColumnName("val_fim_vigencia");

            Property(p => p.ValorHora)
                .HasColumnName("val_hora");

            Property(p => p.ValorAdicional)
                .HasColumnName("val_adicional");
        }

        public override void ConfiguraChavePrimaria()
        {
            HasKey(p => p.ValorId);
        }

        public override void ConfiguraNomeTabela()
        {
            ToTable("tbl_valores");
        }

        public override void ConfiguraRelacionamentos()
        {
            
            HasMany(p => p.ListaMovimentacao);
        }

    }
}
