namespace codefirstdemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class techersnew : DbMigration
    {
        public override void Up()
        {
            Sql("update teachers set department='civil' where teacherid=2");
        }
        
        public override void Down()
        {
        }
    }
}
