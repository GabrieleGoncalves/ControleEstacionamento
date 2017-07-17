namespace ControleEstacionamento.Persistence.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterandoValores : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.tbl_valores", "Veiculo_VeiculoId", "dbo.Veiculoes");
            DropIndex("dbo.tbl_valores", new[] { "Veiculo_VeiculoId" });
            DropColumn("dbo.tbl_valores", "Veiculo_VeiculoId");
            DropTable("dbo.Veiculoes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Veiculoes",
                c => new
                    {
                        VeiculoId = c.Int(nullable: false, identity: true),
                        Placa = c.String(maxLength: 500, unicode: false),
                        Marca = c.String(maxLength: 500, unicode: false),
                        Modelo = c.String(maxLength: 500, unicode: false),
                        NomeCliente = c.String(maxLength: 500, unicode: false),
                    })
                .PrimaryKey(t => t.VeiculoId);
            
            AddColumn("dbo.tbl_valores", "Veiculo_VeiculoId", c => c.Int());
            CreateIndex("dbo.tbl_valores", "Veiculo_VeiculoId");
            AddForeignKey("dbo.tbl_valores", "Veiculo_VeiculoId", "dbo.Veiculoes", "VeiculoId");
        }
    }
}
