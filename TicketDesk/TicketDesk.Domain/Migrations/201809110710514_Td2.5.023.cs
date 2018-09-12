namespace TicketDesk.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Td25023 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tickets", "RequestBy", c => c.String(nullable: true, maxLength: 256));
            AddColumn("dbo.Tickets", "RequestDate", c => c.DateTime(nullable: true));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tickets", "RequestBy");
            DropColumn("dbo.Tickets", "RequestDate");
        }
    }
}
