namespace Team_WASD___Game_Store_Stock_Management_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPublisher : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tblGame", "GamePublisher", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.tblGame", "GamePublisher");
        }
    }
}
