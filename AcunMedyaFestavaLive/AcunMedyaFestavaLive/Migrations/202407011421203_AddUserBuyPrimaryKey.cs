namespace AcunMedyaFestavaLive.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserBuyPrimaryKey : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserBuys",
                c => new
                    {
                        UserBuyId = c.Int(nullable: false, identity: true),
                        NameSurname = c.String(),
                        Email = c.String(),
                        Phone = c.Int(nullable: false),
                        TicketType = c.Int(nullable: false),
                        Number = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserBuyId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserBuys");
        }
    }
}
