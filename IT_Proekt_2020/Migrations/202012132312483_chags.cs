namespace IT_Proekt_2020.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class chags : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clients", "Name", c => c.String());
            AddColumn("dbo.Clients", "Adress", c => c.String());
            AddColumn("dbo.Clients", "Porachki", c => c.Int(nullable: false));
            DropColumn("dbo.Clients", "Ime");
            DropColumn("dbo.Clients", "Adresa");
            DropColumn("dbo.Clients", "Naracki");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Clients", "Naracki", c => c.Int(nullable: false));
            AddColumn("dbo.Clients", "Adresa", c => c.String());
            AddColumn("dbo.Clients", "Ime", c => c.String());
            DropColumn("dbo.Clients", "Porachki");
            DropColumn("dbo.Clients", "Adress");
            DropColumn("dbo.Clients", "Name");
        }
    }
}
