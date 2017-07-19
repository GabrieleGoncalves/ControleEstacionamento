namespace ControleEstacionamento.Persistence.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlternadoCampoMovimentacaoVeiculo : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tbl_movimentacao_veiculo", "mov_saida", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tbl_movimentacao_veiculo", "mov_saida", c => c.DateTime(nullable: false));
        }
    }
}
