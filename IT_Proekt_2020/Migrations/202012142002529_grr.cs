namespace IT_Proekt_2020.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class grr : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clients", "test", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clients", "test");
        }
    }
}
