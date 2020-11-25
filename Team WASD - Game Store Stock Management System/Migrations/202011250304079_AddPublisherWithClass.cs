namespace Team_WASD___Game_Store_Stock_Management_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPublisherWithClass : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Publisher", newName: "tblPublisher");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.tblPublisher", newName: "Publisher");
        }
    }
}
