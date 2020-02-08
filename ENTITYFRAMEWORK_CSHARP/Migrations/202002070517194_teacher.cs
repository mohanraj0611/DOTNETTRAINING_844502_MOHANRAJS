namespace codefirstdemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class teacher : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.teachers",
                
                c => new
                    {
                        teacherID = c.Int(nullable: false, identity: true),//change identity to false for changing primary key
                        name = c.String(),
                        department = c.String(),
                    })
                .PrimaryKey(t => t.teacherID);
            //inserting data into table usnig the raw sql queries
            Sql("insert into teacher values(2,'mohan','science')");
        }
        
        public override void Down()
        {
            DropTable("dbo.teachers");
        }
    }
}
