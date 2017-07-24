namespace ControleEstacionamento.Persistence.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tbl_movimentacao_veiculo",
                c => new
                    {
                        mov_codigo = c.Int(nullable: false, identity: true),
                        mov_placa = c.String(maxLength: 500, unicode: false),
                        mov_nome_cliente = c.String(maxLength: 500, unicode: false),
                        mov_entrada = c.DateTime(nullable: false),
                        mov_saida = c.DateTime(),
                        mov_horas_permanencia = c.Int(),
                        mov_minuto_permanenia = c.Int(),
                        mov_valor_total = c.Double(),
                        ValorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.mov_codigo)
                .ForeignKey("dbo.tbl_valores", t => t.ValorId, cascadeDelete: true)
                .Index(t => t.ValorId);
            
            CreateTable(
                "dbo.tbl_valores",
                c => new
                    {
                        val_codigo = c.Int(nullable: false, identity: true),
                        val_inicio_vigencia = c.DateTime(nullable: false),
                        val_fim_vigencia = c.DateTime(nullable: false),
                        val_hora = c.Double(nullable: false),
                        val_adicional = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.val_codigo);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tbl_movimentacao_veiculo", "ValorId", "dbo.tbl_valores");
            DropIndex("dbo.tbl_movimentacao_veiculo", new[] { "ValorId" });
            DropTable("dbo.tbl_valores");
            DropTable("dbo.tbl_movimentacao_veiculo");
        }
    }
}
