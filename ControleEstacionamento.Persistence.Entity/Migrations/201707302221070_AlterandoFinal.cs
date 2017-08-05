namespace ControleEstacionamento.Persistence.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterandoFinal : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tbl_movimentacao_veiculo", "mov_horas_permanencia", c => c.Int());
            AddColumn("dbo.tbl_movimentacao_veiculo", "mov_minuto_permanenia", c => c.Int());
            AlterColumn("dbo.tbl_movimentacao_veiculo", "mov_valor_total", c => c.Double());
            DropColumn("dbo.tbl_movimentacao_veiculo", "mov_tempo_permanencia");
            DropColumn("dbo.tbl_movimentacao_veiculo", "mov_hora_adicional");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tbl_movimentacao_veiculo", "mov_hora_adicional", c => c.DateTime(nullable: false));
            AddColumn("dbo.tbl_movimentacao_veiculo", "mov_tempo_permanencia", c => c.DateTime(nullable: false));
            AlterColumn("dbo.tbl_movimentacao_veiculo", "mov_valor_total", c => c.Double(nullable: false));
            DropColumn("dbo.tbl_movimentacao_veiculo", "mov_minuto_permanenia");
            DropColumn("dbo.tbl_movimentacao_veiculo", "mov_horas_permanencia");
        }
    }
}
