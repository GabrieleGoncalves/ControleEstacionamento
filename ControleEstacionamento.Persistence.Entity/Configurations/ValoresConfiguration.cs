using ControleEstacionamento.Domain.Entities;
using ControleEstacionamento.Persistence.Entity.TemplateConfiguration;

namespace ControleEstacionamento.Persistence.Entity.Configurations
{
    public class ValoresConfiguration: PersistenceTypeConfiguration<Valores>
    {
        public override void ConfiguraCampos()
        {
            Property(va => va.ValorId)
                .IsRequired()
                .HasColumnName("val_codigo");

            Property(va => va.ValorHoraInicial)
                .HasColumnName("val_hora_inicial");

            Property(va => va.TempoPermanencia)
                .HasColumnName("val_tempo_permanencia");

            Property(va => va.ValorHoraAdicional)
                .HasColumnName("val_hora_adicional");

            Property(va => va.ValorTotal)
                .HasColumnName("val_valor_total");
        }

        public override void ConfiguraChavePrimaria()
        {
            HasKey(val => val.ValorId);
        }

        public override void ConfiguraNomeTabela()
        {
            ToTable("tbl_valores");
        }

        public override void ConfiguraRelacionamentos()
        {
            HasMany(p => p.ListaVeiculo);

        }

    }
}
