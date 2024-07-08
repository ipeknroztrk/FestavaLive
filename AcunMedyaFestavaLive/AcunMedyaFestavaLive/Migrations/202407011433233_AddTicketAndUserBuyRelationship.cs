namespace AcunMedyaFestavaLive.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTicketAndUserBuyRelationship : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserBuys", "TicketId", c => c.Int(nullable: false));
            CreateIndex("dbo.UserBuys", "TicketId");
            AddForeignKey("dbo.UserBuys", "TicketId", "dbo.Tickets", "TicketId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserBuys", "TicketId", "dbo.Tickets");
            DropIndex("dbo.UserBuys", new[] { "TicketId" });
            DropColumn("dbo.UserBuys", "TicketId");
        }
    }
}
