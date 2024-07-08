﻿namespace AcunMedyaFestavaLive.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Artists", "Description2", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Artists", "Description2");
        }
    }
}