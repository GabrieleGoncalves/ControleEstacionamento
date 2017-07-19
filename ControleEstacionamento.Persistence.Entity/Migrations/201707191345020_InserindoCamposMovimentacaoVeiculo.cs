namespace ControleEstacionamento.Persistence.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InserindoCamposMovimentacaoVeiculo : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.tbl_movimentacao_veiculo", name: "TempoPermanecica", newName: "mov_tempo_permanencia");
            RenameColumn(table: "dbo.tbl_movimentacao_veiculo", name: "HoraAdicional", newName: "mov_hora_adicional");
            RenameColumn(table: "dbo.tbl_movimentacao_veiculo", name: "ValorTotal", newName: "mov_valor_total");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.tbl_movimentacao_veiculo", name: "mov_valor_total", newName: "ValorTotal");
            RenameColumn(table: "dbo.tbl_movimentacao_veiculo", name: "mov_hora_adicional", newName: "HoraAdicional");
            RenameColumn(table: "dbo.tbl_movimentacao_veiculo", name: "mov_tempo_permanencia", newName: "TempoPermanecica");
        }
    }
}
