namespace ToyAppChina.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMovie : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Category", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "Category");
        }
    }
}
