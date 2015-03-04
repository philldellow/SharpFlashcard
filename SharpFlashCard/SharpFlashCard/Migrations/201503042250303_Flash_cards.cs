namespace SharpFlashCard.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Flash_cards : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FlashCards",
                c => new
                {
                    Id = c.String(nullable: false, maxLength: 128),
                    Question = c.String(),
                    Answer = c.String(),
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
