namespace LojaDDD.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CorrecaonatabelaprodutoVenda : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.ProdutoVenda");
            AddColumn("dbo.ProdutoVenda", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.ProdutoVenda", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.ProdutoVenda");
            DropColumn("dbo.ProdutoVenda", "Id");
            AddPrimaryKey("dbo.ProdutoVenda", new[] { "VendaId", "ProdutoId" });
        }
    }
}
