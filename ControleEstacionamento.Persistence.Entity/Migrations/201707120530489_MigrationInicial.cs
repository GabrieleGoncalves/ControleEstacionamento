namespace ControleEstacionamento.Persistence.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrationInicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tbl_veiculo",
                c => new
                    {
                        vei_codigo = c.Int(nullable: false, identity: true),
                        vei_placa = c.String(maxLength: 500, unicode: false),
                        vei_marca = c.String(maxLength: 500, unicode: false),
                        vei_modelo = c.String(maxLength: 500, unicode: false),
                        vei_nome_cliente = c.String(maxLength: 500, unicode: false),
                        vei_hora_entrada = c.DateTime(nullable: false),
                        vei_hora_saida = c.DateTime(),
                        ValorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.vei_codigo)
                .ForeignKey("dbo.tbl_valores", t => t.ValorId, cascadeDelete: true)
                .Index(t => t.ValorId);
            
            CreateTable(
                "dbo.tbl_valores",
                c => new
                    {
                        val_codigo = c.Int(nullable: false, identity: true),
                        val_hora_inicial = c.Double(nullable: false),
                        val_tempo_permanencia = c.Double(nullable: false),
                        val_hora_adicional = c.Double(nullable: false),
                        val_valor_total = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.val_codigo);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tbl_veiculo", "ValorId", "dbo.tbl_valores");
            DropIndex("dbo.tbl_veiculo", new[] { "ValorId" });
            DropTable("dbo.tbl_valores");
            DropTable("dbo.tbl_veiculo");
        }
    }
}
