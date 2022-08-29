namespace Assignment_5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingdata2 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Tasks Values( CAST('4:00' AS TIME) , 'owner5', 'done', 'ghghghh')");
            Sql("SELECT * FROM Tasks WHERE Taskid = 1");
        }
        
        public override void Down()
        {
        }
    }
}
