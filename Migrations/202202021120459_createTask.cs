namespace Assignment_5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createTask : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tasks",
                c => new
                    {
                        TaskId = c.Int(nullable: false, identity: true),
                        Time = c.Time(nullable: false, precision: 7),
                        TaskOwner = c.String(),
                        TaskStatus = c.String(),
                        StoryDescription = c.String(),
                    })
                .PrimaryKey(t => t.TaskId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Tasks");
        }
    }
}
