namespace AcunMedyaFestavaLive.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserEntity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        ImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.UserId);
            
            AddColumn("dbo.UserBuys", "User_UserId", c => c.Int());
            CreateIndex("dbo.UserBuys", "User_UserId");
            AddForeignKey("dbo.UserBuys", "User_UserId", "dbo.Users", "UserId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserBuys", "User_UserId", "dbo.Users");
            DropIndex("dbo.UserBuys", new[] { "User_UserId" });
            DropColumn("dbo.UserBuys", "User_UserId");
            DropTable("dbo.Users");
        }
    }
}
