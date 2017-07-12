using ControleEstacionamento.Domain.Entities;
using ControleEstacionamento.Persistence.Entity.TemplateConfiguration;

namespace ControleEstacionamento.Persistence.Entity.Configurations
{
    public class VeiculoConfiguration: PersistenceTypeConfiguration<Veiculo>
    {
        public override void ConfiguraCampos()
        {
            Property(v => v.VeiculoId)
                .IsRequired()
                .HasColumnName("vei_codigo");

            Property(v => v.Placa)
                .HasColumnName("vei_placa");

            Property(v => v.Marca)
                .HasColumnName("vei_marca");

            Property(v => v.Modelo)
                .HasColumnName("vei_modelo");
            
            Property(v => v.NomeCliente)
                .HasColumnName("vei_nome_cliente");

            Property(v => v.HoraEntrada)
                .HasColumnName("vei_hora_entrada");

            Property(v => v.HoraSaida)
                .HasColumnName("vei_hora_saida");
        }

        public override void ConfiguraChavePrimaria()
        {
            HasKey(v => v.VeiculoId);

        }
        public override void ConfiguraNomeTabela()
        {
            ToTable("tbl_veiculo");
        }

        public override void ConfiguraRelacionamentos()
        {
            HasRequired(p => p.Valores)
                .WithMany(p => p.ListaVeiculo)
                .HasForeignKey(p => p.ValorId);
        }

    }
}
