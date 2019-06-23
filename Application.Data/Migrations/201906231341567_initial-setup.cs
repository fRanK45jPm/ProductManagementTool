namespace Application.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialsetup : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        SKU = c.String(nullable: false),
                        Environment = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProductDisplayName",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LocalDisplayName = c.String(),
                        Language = c.Int(nullable: false),
                        Product_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Product", t => t.Product_Id)
                .Index(t => t.Product_Id);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Environment = c.Int(nullable: false),
                        Username = c.String(nullable: false, maxLength: 50),
                        IsSuperUser = c.Boolean(nullable: false),
                        ApiToken = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductDisplayName", "Product_Id", "dbo.Product");
            DropIndex("dbo.ProductDisplayName", new[] { "Product_Id" });
            DropTable("dbo.User");
            DropTable("dbo.ProductDisplayName");
            DropTable("dbo.Product");
        }
    }
}
