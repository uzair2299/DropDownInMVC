namespace DropDownInMVC.Migrations
{
    using DropDownInMVC.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DropDownInMVC.Models.ApplicationContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ApplicationContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            //context.countries.AddOrUpdate(x => x.CountryId, new Country() { CountryName = "Dubai" });
            //context.countries.AddOrUpdate(x => x.CountryId, new Country() { CountryName = "Qatar" });
        }
    }
}
