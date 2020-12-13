namespace IT_Proekt_2020.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class poeni : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clients", "Poeni", c => c.Int(nullable: false));
            DropColumn("dbo.Clients", "Bodovi");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Clients", "Bodovi", c => c.Int(nullable: false));
            DropColumn("dbo.Clients", "Poeni");
        }
    }
}
