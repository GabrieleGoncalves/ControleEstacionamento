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

            Property(p => p.ValorHoraInicial)
                .HasColumnName("val_hora_inicial");

            Property(p => p.TempoPermanencia)
                .HasColumnName("val_tempo_permanencia");

            Property(p => p.ValorHoraAdicional)
                .HasColumnName("val_hora_adicional");

            Property(p => p.ValorTotal)
                .HasColumnName("val_valor_total");
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
            HasRequired(p => p.Veiculo)
                .WithMany(p => p.ListaValores)
                .HasForeignKey(p => p.VeiculoId);
        }

    }
}
