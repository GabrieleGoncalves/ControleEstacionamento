namespace ControleEstacionamento.Persistence.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
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
            
            CreateTable(
                "dbo.tbl_valores",
                c => new
                    {
                        val_codigo = c.Int(nullable: false, identity: true),
                        val_inicio_vigencia = c.DateTime(nullable: false),
                        val_fim_vigencia = c.DateTime(nullable: false),
                        val_hora = c.Double(nullable: false),
                        val_adicional = c.Double(nullable: false),
                        Veiculo_VeiculoId = c.Int(),
                    })
                .PrimaryKey(t => t.val_codigo)
                .ForeignKey("dbo.Veiculoes", t => t.Veiculo_VeiculoId)
                .Index(t => t.Veiculo_VeiculoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tbl_valores", "Veiculo_VeiculoId", "dbo.Veiculoes");
            DropIndex("dbo.tbl_valores", new[] { "Veiculo_VeiculoId" });
            DropTable("dbo.tbl_valores");
            DropTable("dbo.Veiculoes");
        }
    }
}
