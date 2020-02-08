namespace codefirstdemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class productcreated : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.categories",
                c => new
                    {
                        categoryID = c.Int(nullable: false, identity: true),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.categoryID);
            
            CreateTable(
                "dbo.products",
                c => new
                    {
                        productId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        price = c.Double(nullable: false),
                        quantity = c.String(),
                        categoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.productId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.products");
            DropTable("dbo.categories");
        }
    }
}
