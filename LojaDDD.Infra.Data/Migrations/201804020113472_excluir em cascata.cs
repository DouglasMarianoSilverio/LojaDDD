namespace LojaDDD.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class excluiremcascata : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ProdutoVenda", "VendaId", "dbo.Venda");
            AddForeignKey("dbo.ProdutoVenda", "VendaId", "dbo.Venda", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProdutoVenda", "VendaId", "dbo.Venda");
            AddForeignKey("dbo.ProdutoVenda", "VendaId", "dbo.Venda", "Id");
        }
    }
}
