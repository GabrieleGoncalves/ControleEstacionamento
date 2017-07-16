using ControleEstacionamento.Domain.Entities;
using ControleEstacionamento.Persistence.Entity.TemplateConfiguration;

namespace ControleEstacionamento.Persistence.Entity.Configurations
{
    public class VeiculoConfiguration: PersistenceTypeConfiguration<Veiculo>
    {
        public override void ConfiguraCampos()
        {
            Property(p => p.VeiculoId)
                .IsRequired()
                .HasColumnName("vei_codigo");

            Property(p => p.Placa)
                .HasColumnName("vei_placa");

            Property(p => p.Marca)
                .HasColumnName("vei_marca");

            Property(p => p.Modelo)
                .HasColumnName("vei_modelo");
            
            Property(p => p.NomeCliente)
                .HasColumnName("vei_nome_cliente");

            Property(p => p.HoraEntrada)
                .HasColumnName("vei_hora_entrada");

            Property(p => p.HoraSaida)
                .HasColumnName("vei_hora_saida");
        }

        public override void ConfiguraChavePrimaria()
        {
            HasKey(p => p.VeiculoId);

        }
        public override void ConfiguraNomeTabela()
        {
            ToTable("tbl_veiculo");
        }

        public override void ConfiguraRelacionamentos()
        {
            HasMany(p => p.ListaValores);
        }

    }
}
