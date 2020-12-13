namespace IT_Proekt_2020.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clients", "Ime", c => c.String());
            AddColumn("dbo.Clients", "Adresa", c => c.String());
            AddColumn("dbo.Clients", "Naracki", c => c.Int(nullable: false));
            DropColumn("dbo.Clients", "Name");
            DropColumn("dbo.Clients", "Adress");
            DropColumn("dbo.Clients", "Porachki");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Clients", "Porachki", c => c.Int(nullable: false));
            AddColumn("dbo.Clients", "Adress", c => c.String());
            AddColumn("dbo.Clients", "Name", c => c.String());
            DropColumn("dbo.Clients", "Naracki");
            DropColumn("dbo.Clients", "Adresa");
            DropColumn("dbo.Clients", "Ime");
        }
    }
}
