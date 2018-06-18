namespace Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AmigoEdit : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Amigo", "Pais_Id", "dbo.Pais");
            DropIndex("dbo.Amigo", new[] { "Pais_Id" });
            DropColumn("dbo.Amigo", "Pais_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Amigo", "Pais_Id", c => c.Int());
            CreateIndex("dbo.Amigo", "Pais_Id");
            AddForeignKey("dbo.Amigo", "Pais_Id", "dbo.Pais", "Id");
        }
    }
}
