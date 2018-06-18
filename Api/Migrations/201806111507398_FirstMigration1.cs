namespace Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration1 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Amigoes", newName: "Amigo");
            RenameTable(name: "dbo.Estadoes", newName: "Estado");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Estado", newName: "Estadoes");
            RenameTable(name: "dbo.Amigo", newName: "Amigoes");
        }
    }
}
