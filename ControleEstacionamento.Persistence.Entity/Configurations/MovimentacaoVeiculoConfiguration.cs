using ControleEstacionamento.Domain.Entities;
using ControleEstacionamento.Persistence.Entity.TemplateConfiguration;

namespace ControleEstacionamento.Persistence.Entity.Configurations
{
    public class MovimentacaoVeiculoConfiguration: PersistenceTypeConfiguration<MovimentacaoVeiculo>
    {
        public override void ConfiguraCampos()
        {
            Property(p => p.MovimentacaoVeiculoId)
                .IsRequired()
                .HasColumnName("mov_codigo");

            Property(p => p.Placa)
                .HasColumnName("mov_placa");

            Property(p => p.NomeCliente)
                .HasColumnName("mov_nome_cliente");
            
            Property(p => p.Entrada)
                .HasColumnName("mov_entrada");

            Property(p => p.Saida)
                .IsOptional()
                .HasColumnName("mov_saida");

            Property(p => p.HorasPermanencia)
                .IsOptional()
                .HasColumnName("mov_horas_permanencia");

            Property(p => p.MinutosPermanencia)
                .IsOptional()
                .HasColumnName("mov_minuto_permanenia");

            Property(p => p.ValorTotal)
                .IsOptional()
                .HasColumnName("mov_valor_total");

        }

        public override void ConfiguraChavePrimaria()
        {
            HasKey(p => p.MovimentacaoVeiculoId);

        }
        public override void ConfiguraNomeTabela()
        {
            ToTable("tbl_movimentacao_veiculo");
        }

        public override void ConfiguraRelacionamentos()
        {
            HasRequired(p => p.Valor)
                .WithMany(p => p.ListaMovimentacao)
                .HasForeignKey(p => p.ValorId);
        }
    
    }
}
