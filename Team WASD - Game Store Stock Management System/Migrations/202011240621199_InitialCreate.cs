namespace Team_WASD___Game_Store_Stock_Management_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblGame",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GameTitle = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tblGame");
        }
    }
}
