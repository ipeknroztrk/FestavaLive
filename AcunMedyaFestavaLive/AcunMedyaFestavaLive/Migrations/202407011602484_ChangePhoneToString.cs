namespace AcunMedyaFestavaLive.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangePhoneToString : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.UserBuys", "Phone", c => c.String());
            DropColumn("dbo.UserBuys", "TicketType");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserBuys", "TicketType", c => c.Int(nullable: false));
            AlterColumn("dbo.UserBuys", "Phone", c => c.Int(nullable: false));
        }
    }
}
