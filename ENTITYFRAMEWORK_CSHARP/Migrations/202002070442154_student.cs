namespace codefirstdemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class student : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.students",
                c => new
                    {
                        studentID = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        department = c.String(),
                    })
                .PrimaryKey(t => t.studentID);
           
            
        }
        
        public override void Down()
        {
            DropTable("dbo.students");
        }
    }
}
