namespace Midterm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CoursesAvailables",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CourseName = c.String(),
                        CourseDescription = c.String(),
                        TutorName = c.String(),
                        CourseRating = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Students", "CoursesId", c => c.Int(nullable: false));
            AddColumn("dbo.Students", "CoursesAvailable_Id", c => c.Int());
            CreateIndex("dbo.Students", "CoursesAvailable_Id");
            AddForeignKey("dbo.Students", "CoursesAvailable_Id", "dbo.CoursesAvailables", "Id");
            DropColumn("dbo.Students", "CourseId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "CourseId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Students", "CoursesAvailable_Id", "dbo.CoursesAvailables");
            DropIndex("dbo.Students", new[] { "CoursesAvailable_Id" });
            DropColumn("dbo.Students", "CoursesAvailable_Id");
            DropColumn("dbo.Students", "CoursesId");
            DropTable("dbo.CoursesAvailables");
        }
    }
}
