namespace Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AmigoLocalization : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Amigo", "Estado_Id", c => c.Int());
            AddColumn("dbo.Amigo", "Pais_Id", c => c.Int());
            CreateIndex("dbo.Amigo", "Estado_Id");
            CreateIndex("dbo.Amigo", "Pais_Id");
            AddForeignKey("dbo.Amigo", "Estado_Id", "dbo.Estado", "Id");
            AddForeignKey("dbo.Amigo", "Pais_Id", "dbo.Pais", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Amigo", "Pais_Id", "dbo.Pais");
            DropForeignKey("dbo.Amigo", "Estado_Id", "dbo.Estado");
            DropIndex("dbo.Amigo", new[] { "Pais_Id" });
            DropIndex("dbo.Amigo", new[] { "Estado_Id" });
            DropColumn("dbo.Amigo", "Pais_Id");
            DropColumn("dbo.Amigo", "Estado_Id");
        }
    }
}
