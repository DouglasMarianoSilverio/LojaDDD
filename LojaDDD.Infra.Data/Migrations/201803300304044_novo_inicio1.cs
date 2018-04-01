namespace LojaDDD.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class novo_inicio1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cliente", "Telefone", c => c.String(maxLength: 100, unicode: false));
            DropColumn("dbo.Cliente", "DataCadastro");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cliente", "DataCadastro", c => c.DateTime(nullable: false));
            DropColumn("dbo.Cliente", "Telefone");
        }
    }
}
