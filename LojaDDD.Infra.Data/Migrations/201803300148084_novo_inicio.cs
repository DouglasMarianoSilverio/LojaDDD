namespace LojaDDD.Infra.Data.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class novo_inicio : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 150, unicode: false),
                        DataNascimento = c.DateTime(nullable: false),
                        CPF = c.String(nullable: false, maxLength: 100, unicode: false),
                        Email = c.String(nullable: false, maxLength: 100, unicode: false),
                        DataCadastro = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Venda",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClienteId = c.Int(nullable: false),
                        DataVenda = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cliente", t => t.ClienteId)
                .Index(t => t.ClienteId);
            
            CreateTable(
                "dbo.ProdutoVenda",
                c => new
                    {
                        VendaId = c.Int(nullable: false),
                        ProdutoId = c.Int(nullable: false),
                        Quantidade = c.Int(nullable: false),
                        ValorUnitario = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ValorTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => new { t.VendaId, t.ProdutoId })
                .ForeignKey("dbo.Produto", t => t.ProdutoId)
                .ForeignKey("dbo.Venda", t => t.VendaId)
                .Index(t => t.VendaId)
                .Index(t => t.ProdutoId);
            
            CreateTable(
                "dbo.Produto",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 250, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Venda", "ClienteId", "dbo.Cliente");
            DropForeignKey("dbo.ProdutoVenda", "VendaId", "dbo.Venda");
            DropForeignKey("dbo.ProdutoVenda", "ProdutoId", "dbo.Produto");
            DropIndex("dbo.ProdutoVenda", new[] { "ProdutoId" });
            DropIndex("dbo.ProdutoVenda", new[] { "VendaId" });
            DropIndex("dbo.Venda", new[] { "ClienteId" });
            DropTable("dbo.Produto");
            DropTable("dbo.ProdutoVenda");
            DropTable("dbo.Venda");
            DropTable("dbo.Cliente");
        }
    }
}
