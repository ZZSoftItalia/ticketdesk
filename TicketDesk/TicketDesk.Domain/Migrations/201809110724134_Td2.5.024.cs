namespace TicketDesk.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Td25024 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tickets", "RequestedBy", c => c.String(maxLength: 256));
            AddColumn("dbo.Tickets", "RequestedDate", c => c.DateTime());
            DropColumn("dbo.Tickets", "RequestBy");
            DropColumn("dbo.Tickets", "RequestDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tickets", "RequestDate", c => c.DateTime());
            AddColumn("dbo.Tickets", "RequestBy", c => c.String(maxLength: 256));
            DropColumn("dbo.Tickets", "RequestedDate");
            DropColumn("dbo.Tickets", "RequestedBy");
        }
    }
}
