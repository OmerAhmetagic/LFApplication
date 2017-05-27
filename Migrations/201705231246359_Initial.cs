namespace LFApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false),
                        Location = c.String(nullable: false),
                        Tag = c.String(nullable: false),
                        Image = c.Binary(),
                        Comment = c.String(),
                        PersonName = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Phone = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LostItems",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false),
                        Location = c.String(nullable: false),
                        Tag = c.String(nullable: false),
                        Image = c.Binary(),
                        Comment = c.String(),
                        PersonName = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Phone = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.LostItems");
            DropTable("dbo.Items");
        }
    }
}
