namespace Team_WASD___Game_Store_Stock_Management_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddVarousModels : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblGenre",
                c => new
                    {
                        GenreId = c.Int(nullable: false, identity: true),
                        GenreName = c.String(),
                    })
                .PrimaryKey(t => t.GenreId);
            
            CreateTable(
                "dbo.tblPlatform",
                c => new
                    {
                        PlatformId = c.Int(nullable: false, identity: true),
                        PlatformName = c.String(),
                    })
                .PrimaryKey(t => t.PlatformId);
            
            AddColumn("dbo.tblGame", "ReleaseDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.tblGame", "Description", c => c.String());
            AddColumn("dbo.tblGame", "InStockAmount", c => c.Int(nullable: false));
            AddColumn("dbo.tblGame", "Genre_GenreId", c => c.Int());
            AddColumn("dbo.tblGame", "Platform_PlatformId", c => c.Int());
            CreateIndex("dbo.tblGame", "Genre_GenreId");
            CreateIndex("dbo.tblGame", "Platform_PlatformId");
            AddForeignKey("dbo.tblGame", "Genre_GenreId", "dbo.tblGenre", "GenreId");
            AddForeignKey("dbo.tblGame", "Platform_PlatformId", "dbo.tblPlatform", "PlatformId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tblGame", "Platform_PlatformId", "dbo.tblPlatform");
            DropForeignKey("dbo.tblGame", "Genre_GenreId", "dbo.tblGenre");
            DropIndex("dbo.tblGame", new[] { "Platform_PlatformId" });
            DropIndex("dbo.tblGame", new[] { "Genre_GenreId" });
            DropColumn("dbo.tblGame", "Platform_PlatformId");
            DropColumn("dbo.tblGame", "Genre_GenreId");
            DropColumn("dbo.tblGame", "InStockAmount");
            DropColumn("dbo.tblGame", "Description");
            DropColumn("dbo.tblGame", "ReleaseDate");
            DropTable("dbo.tblPlatform");
            DropTable("dbo.tblGenre");
        }
    }
}
