namespace LojaDDD.Infra.Data.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Context.LojaDDDContext>
    {
        public Configuration()
        {
            //true para modificar automaticamente.
            AutomaticMigrationsEnabled = false;
        }        

        protected override void Seed(Context.LojaDDDContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
