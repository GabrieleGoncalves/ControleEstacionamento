namespace ControleEstacionamento.Persistence.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InserindoCampos : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tbl_movimentacao_veiculo", "TempoPermanecica", c => c.DateTime(nullable: false));
            AddColumn("dbo.tbl_movimentacao_veiculo", "HoraAdicional", c => c.DateTime(nullable: false));
            AddColumn("dbo.tbl_movimentacao_veiculo", "ValorTotal", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tbl_movimentacao_veiculo", "ValorTotal");
            DropColumn("dbo.tbl_movimentacao_veiculo", "HoraAdicional");
            DropColumn("dbo.tbl_movimentacao_veiculo", "TempoPermanecica");
        }
    }
}
