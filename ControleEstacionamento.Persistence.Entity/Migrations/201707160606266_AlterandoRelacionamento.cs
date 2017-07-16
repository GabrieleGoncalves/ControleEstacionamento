namespace ControleEstacionamento.Persistence.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterandoRelacionamento : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.tbl_veiculo", "ValorId", "dbo.tbl_valores");
            DropIndex("dbo.tbl_veiculo", new[] { "ValorId" });
            AddColumn("dbo.tbl_valores", "VeiculoId", c => c.Int(nullable: false));
            CreateIndex("dbo.tbl_valores", "VeiculoId");
            AddForeignKey("dbo.tbl_valores", "VeiculoId", "dbo.tbl_veiculo", "vei_codigo", cascadeDelete: true);
            DropColumn("dbo.tbl_veiculo", "ValorId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tbl_veiculo", "ValorId", c => c.Int(nullable: false));
            DropForeignKey("dbo.tbl_valores", "VeiculoId", "dbo.tbl_veiculo");
            DropIndex("dbo.tbl_valores", new[] { "VeiculoId" });
            DropColumn("dbo.tbl_valores", "VeiculoId");
            CreateIndex("dbo.tbl_veiculo", "ValorId");
            AddForeignKey("dbo.tbl_veiculo", "ValorId", "dbo.tbl_valores", "val_codigo", cascadeDelete: true);
        }
    }
}
