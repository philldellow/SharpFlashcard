namespace SharpFlashCard.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class flashcard_table : DbMigration
    {
        public override void Up()
        {
            CreateTable(
               "dbo.FlashCards",
               c => new
               {
                   Id = c.Int(nullable: false, identity: true),
                   Question = c.String(nullable: true),
                   Answer = c.String(nullable: true),
               })
               .PrimaryKey(t => t.Id);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FlashCards", "Id", "dbo.FlashCards");
            DropTable("dbo.FlashCards");
        }
    }
}
