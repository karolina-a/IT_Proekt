namespace IT_Proekt_2020.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Veronika : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clients", "Veronika", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clients", "Veronika");
        }
    }
}
