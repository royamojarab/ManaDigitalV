﻿namespace dataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initnew1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.people", "birthDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.people", "birthDate", c => c.DateTime(nullable: false));
        }
    }
}
