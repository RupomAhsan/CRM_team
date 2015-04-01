namespace CRM_team.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using CRM_team.People;
    internal sealed class Configuration : DbMigrationsConfiguration<CRM_team.EntityFramework.CRM_teamDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "CRM_team";
        }

        protected override void Seed(CRM_team.EntityFramework.CRM_teamDbContext context)
        {
            // This method will be called every time after migrating to the latest version.
            // You can add any seed data here...
            context.People.AddOrUpdate(
                p => p.Name,
                new Person { Name = "Isaac Asimov" },
                new Person { Name = "Thomas More" },
                new Person { Name = "George Orwell" },
                new Person { Name = "Douglas Adams" }
                );
        }
    }
}
