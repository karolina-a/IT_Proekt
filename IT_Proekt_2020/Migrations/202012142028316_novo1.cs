namespace IT_Proekt_2020.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class novo1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Clients", "broj");
            DropColumn("dbo.Clients", "vozrast");
            DropColumn("dbo.Clients", "asd");
            DropColumn("dbo.Clients", "Veronika");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Clients", "Veronika", c => c.String());
            AddColumn("dbo.Clients", "asd", c => c.Int(nullable: false));
            AddColumn("dbo.Clients", "vozrast", c => c.Int(nullable: false));
            AddColumn("dbo.Clients", "broj", c => c.Int(nullable: false));
        }
    }
}
