namespace DropDownInMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Seed_Countries : DbMigration
    {
        public override void Up()
        {
            Sql("insert into countries(CountryName) values('Pakistan')");
            Sql("insert into countries(CountryName) values('Japan')");
            Sql("insert into countries(CountryName) values('India')");
            Sql("insert into countries(CountryName) values('china')");
            Sql("insert into countries(CountryName) values('USA')");
        }
        
        public override void Down()
        {
        }
    }
}
